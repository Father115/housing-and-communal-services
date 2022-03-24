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

namespace Dashboard1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Setting.xaml
    /// </summary>
    public partial class Setting : Page
    {
        Housing_officeEntities db = new Housing_officeEntities();
        User user;

        public Setting()
        {
            InitializeComponent();
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

            bool allFieldsAreFilled = new List<string>() { secondName, name, 
                lastName,  login, password, EmtxbEmailail, telefon }.All(x => !string.IsNullOrEmpty(x));

            if (allFieldsAreFilled)
            { 
                bool result = UpdateChange.changeUsers( secondName, name, lastName, login,
                password, telefon, EmtxbEmailail, db);
                if (result)
                {
                    MessageBox.Show("Данные успешно обновлены в бд", "Успешно",
                    MessageBoxButton.OK, MessageBoxImage.Information);
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
    }
    }

