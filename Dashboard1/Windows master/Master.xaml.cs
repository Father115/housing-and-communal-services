﻿using Dashboard1.Pages;
using Dashboard1.Pages_admin;
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
    public partial class Master : Window
    {
        public Master()
        {
            InitializeComponent();
            connection.Model1 = new Housing_officeEntities();
            AppFrame.frameMain_master = FrmMain3;
            FrmMain3.Navigate(new Admin_panel());

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

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_master.Navigate(new ГлавнаяСтраница());
        }

        private void RegistrationWorker_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_master.Navigate(new RegistrationWorker());
        }

        private void SendtheWizard_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_master.Navigate(new Send_the_Wizard());
        }

        private void SendingAReceipt_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_master.Navigate(new Sending_a_Receipt());
        }

        private void DataPeople_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain_master.Navigate(new Data_about_People());
        }
    }

}
