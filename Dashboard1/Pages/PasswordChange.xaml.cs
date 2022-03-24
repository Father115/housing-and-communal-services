using Dashboard1.Сlasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для PasswordChange.xaml
    /// </summary>
    public partial class PasswordChange : Page
    {
        Housing_officeEntities db = new Housing_officeEntities();
      
        public PasswordChange()
        {
            InitializeComponent();
        }
  
     
 

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Email = txbEmail.Text;
            string Password_new1 = txbPass_old.Text;
            string Password_new = txbPass_new.Text;

            string password = txbPass_new1.Text;

            bool allFieldsAreFilled = new List<string>() { Email, password }.All(x => !string.IsNullOrEmpty(x));

            if (allFieldsAreFilled)
            {


                bool result = UpdateChange.changeUser(Email, password,  db );
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

        private void generatePasswordupdateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 8; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            string newPassword = builder.ToString();
            txbPass_new1.Text = newPassword;
        }
    }
}

