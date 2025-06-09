using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

        }


        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(@"data source=DESKTOP-M6BHTCC;initial catalog=Складской_учет_одежды;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            DataTable user_con = Select("select * from аунтификация_сотрудника where логин = '" + TxtBxLogin.Text + "' and пароль = '" + TxtBxPas.Password + "' ");
            if (user_con.Rows.Count > 0)
            {

                Glavnaya MainWindow = new Glavnaya();
                MainWindow.Show();
                this.Close();
            }
            else if (TxtBxLogin.Text == "" || TxtBxPas == null)
            {
                MessageBox.Show("Введите логин или пароль");
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

    }
}
