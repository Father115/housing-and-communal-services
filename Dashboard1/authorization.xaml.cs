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
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Window
    {
        SqlConnection loginCon = new SqlConnection("Data Source=DESKTOP-EJVKJKV\\STALKEROS;Initial Catalog=Housing office;Integrated Security=True");
        public authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loginCon.Open();
            SqlDataAdapter loginAdapter = new SqlDataAdapter("SELECT [ID_Тип_пользователя] FROM [dbo].[User] WHERE Login ='" + TextBox.TextInputEvent + "' and Passowrd ='" + PasswordBox.TextInputEvent + "'  ", loginCon);
            // DataTable result = new DataTable();
            //loginAdapter.Fill(result);
            //try
            // {
            //     if (result.Rows.Count == 1)
            //     {
            //   switch (result.Rows[0]["ID_Тип_пользователя"] as string)
            //  {
            //             case "1":
            //  {
            //  this.Hide();
            // Map aMenu = new Map();
            // MessageBox.Show("Авторизация прошла успешна. Добро пожаловать " + TextBox.TextInputEvent + " !!");
            // aMenu.Show();
            // break;
            //  }
            //             case "2":
            //  {
            // this.Hide();
            //    MainWindow pMenu = new MainWindow();
            //  MessageBox.Show("Авторизация прошла успешна. Добро пожаловать " + TextBox.TextInputEvent + " !!");
            //   pMenu.Show();
            //  break;
            //    }
            //    }
            // }
            //  }
            //  catch (SqlException ex)
            //  {
            //  MessageBox.Show(ex.Message);
            //    loginCon.Close();
            //    }
            MessageBox.Show("Авторизация прошла успешна. Добро пожаловать " + TextBox.TextInputEvent + " !!");
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reg taskWindow = new Reg();
            taskWindow.Show();
        }

        private void TextBox_Login(object sender, TextChangedEventArgs e)
        {

        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
