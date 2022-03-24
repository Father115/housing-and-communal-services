using Dashboard1.Сlasses;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Authorizationiz.xaml
    /// </summary>
    public partial class Authorizationiz : Page
    {
        public Authorizationiz()
        {
            InitializeComponent();

        }

        public string txblogin1 { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user0bj = connection.Model1.User.FirstOrDefault(x => x.Login == txblogin.Text && x.Passowrd == psbPasswordBox.Password);
                if (user0bj == null)
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    switch (user0bj.ID_Тип_пользователя)
                    {
                        case 1:
                            Admin aMenu = new Admin();
                            MessageBox.Show("Здравствуйте, Администратор " + user0bj.Login + "!",
     "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Application.Current.MainWindow.Close();
                            aMenu.Show();
                            break;
                        case 2:
                            MainWindow aMenu1 = new MainWindow();
                            MessageBox.Show("Здравствуйте, Пользователь " + user0bj.Login + "!",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Application.Current.MainWindow.Close();
                            aMenu1.Show();
                            break;
                        case 3:
                            Master aMenu2 = new Master();
                            MessageBox.Show("Здравствуйте, Мастер " + user0bj.Login + "!",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Application.Current.MainWindow.Close();
                            aMenu2.Show();
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                        
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка " + Ex.Message.ToString() + "Критическая работа приложения!",
                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Registration());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PasswordChange());

        }

        private void txblogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
