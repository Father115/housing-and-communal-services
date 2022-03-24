﻿using System;
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
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Логика взаимодействия для Apartment_Не_работает_.xaml
    /// </summary>
    public partial class Apartment : Window
    {
        public Apartment()
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

        private void Map_Click(object sender, RoutedEventArgs e)
        {
            map_1 taskWindow = new map_1();
            taskWindow.Show();
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
                Application.Current.MainWindow.Close();
                this.Hide();
                f1.Show();
            }
        }

        private void Apartment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            Visibility = Visibility.Hidden;
            b.ShowDialog();
        }

    }
}
