using Dashboard1.Pages;
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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            connection.Model1 = new Housing_officeEntities();
            AppFrame.frameMain_user = FrmMain1;
            FrmMain1.Navigate(new ГлавнаяСтраница());

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

        private void Map_Click(object sender, RoutedEventArgs e)
        {

            AppFrame.frameMain_user.Navigate(new MapWorld());
        }

        private void Rollup_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            Feedback f9 = new Feedback();
            f9.Show();
        }
        private void Relog_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти из аккаунта?", "Предупреждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                authorization f1 = new authorization();
                this.Close();
                f1.Show();
            }
        }

        private void Apartment_Click(object sender, RoutedEventArgs e)
        {


            AppFrame.frameMain_user.Navigate(new ДанныеКвартиры());

        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_user.Navigate(new PaymentofRent());
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_user.Navigate(new ГлавнаяСтраница());
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_user.Navigate(new Setting());


        }

        private void History_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CalltheWizard_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_user.Navigate(new CalltheWizard());
        }
    }


}
