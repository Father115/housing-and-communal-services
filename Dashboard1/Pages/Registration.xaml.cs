using Dashboard1.Сlasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
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
                    Login = txbLogin.Text,
                    Фамилия = txbSurname.Text,
                    Имя = txbName.Text,
                    Отчество = txbPatronymic.Text,
                    Телефон = txbphone.Text,
                    Email = txbEmail.Text,
                    Passowrd = txbPass.Text,
                    
                    ID_Тип_пользователя = 2
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}

