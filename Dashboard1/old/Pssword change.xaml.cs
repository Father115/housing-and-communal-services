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
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Логика взаимодействия для Pssword_change.xaml
    /// </summary>
    public partial class Pssword_change : Window
    {
        public SqlConnection connString = new SqlConnection(@"Data Source=DESKTOP-EJVKJKV\STALKEROS;Initial Catalog=Housing office;Integrated Security=True");
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable table = new DataTable();
        public Pssword_change()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string EmailUser = txbEmail.Text;
            string OldpassUser = txbPass_old.Text;
            string NewpassUser = txbPass_new.Text;
            SqlCommand command = new SqlCommand("SELECT Count(*) FROM [User] WHERE Email=@uL and Passowrd=@uP", connString);
            command.Parameters.Add("@uL", SqlDbType.NVarChar, 20).Value = EmailUser;
            command.Parameters.Add("@uP", SqlDbType.NVarChar, 20).Value = OldpassUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
                using (SqlConnection sc = new SqlConnection())
                {
                    sc.ConnectionString = (@"Data Source=DESKTOP-EJVKJKV\STALKEROS;Initial Catalog=Housing office;Integrated Security=True");
                    sc.Open();
                    using (SqlCommand com = sc.CreateCommand())
                    {
                        com.CommandText =
                           "update [User] set [Passowrd]=@New, Email=@uL";
                        com.Parameters.Add("@uL", SqlDbType.NVarChar, 20).Value = EmailUser;
                        com.Parameters.Add("@New", SqlDbType.NVarChar, 20).Value = NewpassUser;
                        com.ExecuteNonQuery();
                        MessageBox.Show("Пароль успешно изменен");
                    }
                }
            }
            else
            {
                MessageBox.Show("Произошла ошибка. Проверьте правильность данных");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            authorization f1 = new authorization();
            this.Hide();
            f1.Show();
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

        private void Relog_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти из аккаунта?", "Предупреждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                authorization f1 = new authorization();
                this.Hide();
                f1.Show();
            }
        }
    }
}

