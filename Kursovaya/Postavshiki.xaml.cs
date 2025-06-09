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
using System.Windows.Shapes;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Postavshiki.xaml
    /// </summary>
    public partial class Postavshiki : Window
    {
        Entities_Sklad_tovar database = new Entities_Sklad_tovar();

        public Postavshiki()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            Entities_Sklad_tovar = new Entities_Sklad_tovar();
            DtGrdPostavki.ItemsSource = Entities_Sklad_tovar.товары.ToList();
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

        private Entities_Sklad_tovar Entities_Sklad_tovar;


        //переход на окно Главная
        private void LabelGlavnaya_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
            this.Close();
        }


        //переход на окно товары
        private void LabelTovari_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tovari Glavnaya = new Tovari();
            Glavnaya.Show();
            this.Close();
        }

        //переход на окно Инвентаризация
        private void LabelInventariz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inventarizatsiya Glavnaya = new Inventarizatsiya();
            Glavnaya.Show();
            this.Close();
        }

        //переход на окно Поставщики
        private void LabelPostavshiki_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Postavshiki Glavnaya = new Postavshiki();
            Glavnaya.Show();
            this.Close();
        }

        //переход на окно Склад
        private void LabelSklad_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sklad Glavnaya = new Sklad();
            Glavnaya.Show();
            this.Close();
        }
    }
}
