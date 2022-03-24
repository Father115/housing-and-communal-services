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
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Логика взаимодействия для Feedback.xaml
    /// </summary>
    public partial class Feedback : Window
    {
        public Feedback()
        {
            InitializeComponent();
        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите закрыть приложение?", "Предупреждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Rollup_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow f2 = new MainWindow();
            Visibility = Visibility.Hidden;
        }
        private void Relog_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти из аккаунта?", "Предупреждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                authorization f1 = new authorization();
                Application.Current.MainWindow.Close();
                Visibility = Visibility.Hidden;
                f1.Show();
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress(txbEmail.Text,txbName.Text);
            // кому отправляем
            MailAddress to = new MailAddress("youth42ru@gmail.com", "Tom");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Обратная связь ЖКХ ООО «Мир» ";
            // текст письма
            m.Body = txbEmail.Text + letter.Text;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("youth42ru@gmail.com", "ASDFF1234567890as");
            smtp.EnableSsl = true;
            smtp.Send(m);
            MessageBox.Show("Cообщение успешно отправленно!","Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Console.Read();
        }
    }
}
