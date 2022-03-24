using Dashboard1.Сlasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class RegistrationWorker : Page
    {
        Housing_officeEntities db = new Housing_officeEntities();
        User user;
        public RegistrationWorker()
        {
            InitializeComponent();
            updateRoles();
            updateRoles2();
            RefreshUserToChangeComboBox();
        }

        // Регистрация рабочего 
        public void updateRoles()
        {
            foreach (var role in connection.Model1.User_type.ToList())
            {
                txbroles.Items.Add(role.Название);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (connection.Model1.User.Count(x => x.Login == txbLogin.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким логином есть!",
                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                User userObj = new User()
                {
                    Фамилия = txbSurname.Text,
                    Имя = txbName.Text,
                    Отчество = txbPatronymic.Text,
                    Телефон = txbphone.Text,
                    Email = txbEmail.Text,
                    Login = txbLogin.Text,
                    Passowrd = txbPass.Text,
                    User_type  = connection.Model1.User_type.Where(r => r.Название == txbroles.Text).FirstOrDefault(),
                };
                connection.Model1.User.Add(userObj); connection.Model1.SaveChanges(); MessageBox.Show("Данные успешно добавлены!",
"Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!",
      "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("youth42ru@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress(txbEmail.Text, txbName.Text);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Регистрация в системе Жэк «Мир» ";
            // текст письма
            m.Body = "Логин = " + txbLogin.Text +
                " Пароль = " + txbPass.Text +
                " Почта = " + txbEmail.Text;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("youth42ru@gmail.com", "ASDFF1234567890as");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }

// Смена данных
        public void updateRoles2()
        {
            rolesComboBox.ItemsSource = db.User_type.ToList();
            rolesComboBox.DisplayMemberPath = "Название";
            rolesComboBox.SelectedValuePath = "RoleId";
        }


        public void RefreshUserToChangeComboBox()
        {
            userToChangeComboBox.ItemsSource = db.User.Select(u => new
            {
                UsersId = u.ID_Пользователь,
                Name = "ФИО: " + u.Фамилия + " " + u.Имя + " " + u.Отчество
            }).ToList();
            userToChangeComboBox.DisplayMemberPath = "Name";
            userToChangeComboBox.SelectedValuePath = "UsersId";

        }
        private void rolesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rolesComboBox.ItemsSource = db.User_type.ToList();
            rolesComboBox.DisplayMemberPath = "Название";
            rolesComboBox.SelectedValuePath = "RoleId";
        }

        private void btnUpdaye_Click(object sender, RoutedEventArgs e)
        {
            string secondName = txbSurname1.Text;
            string name = txbName1.Text;
            string lastName = txbPatronymic1.Text;
            string login = txbLogin1.Text;
            string password = txbPass1.Text;
            string telefon = txbphone1.Text;
            string EmtxbEmailail = txbEmail1.Text;

            bool allFieldsAreFilled = new List<string>() { secondName, name, userToChangeComboBox.Text,
                rolesComboBox.Text, lastName,  login, password, EmtxbEmailail, telefon }.All(x => !string.IsNullOrEmpty(x));

            if (allFieldsAreFilled)
            {
                int Id = (int)userToChangeComboBox.SelectedValue;
                int ID_Тип_пользователя = (int)rolesComboBox.SelectedValue;

                bool result = UpdateChange.changeuser(ID_Тип_пользователя, Id, secondName, name, lastName,  login,
                password, telefon, EmtxbEmailail,  db);
                if (result)
                {
                    MessageBox.Show("Данные успешно обновлены в бд", "Успешно",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                    RefreshUserToChangeComboBox();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка на стороне сервера", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Предупреждение",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void userToChangeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (userToChangeComboBox.SelectedValue == null)
            {
                userToChangeComboBox.SelectedValue = user.ID_Пользователь;
            }
            else
            {
                int ID = (int)userToChangeComboBox.SelectedValue;
                user = db.User.Find(ID);
            }


            txbSurname1.Text = user.Фамилия;
            txbName1.Text = user.Имя;
            txbPatronymic1.Text = user.Отчество;
            txbEmail1.Text = user.Email;
            txbphone1.Text = user.Телефон;

            txbLogin1.Text = user.Login;
            txbPass1.Text = user.Passowrd;
            psbPass1.Password = user.Passowrd;


            rolesComboBox.SelectedIndex = rolesComboBox.Items.IndexOf(user.User_type.Название);

        }


    }
}

