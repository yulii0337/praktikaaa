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
using System.Data.Entity;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Tovari.xaml
    /// </summary>
    public partial class Tovari : Window
    {
        Entities_Sklad_tovar database = new Entities_Sklad_tovar();

        //Складской_учет_одеждыEntities cont = new Складской_учет_одеждыEntities();
        public Tovari()
        {
            InitializeComponent();
            //Складской_учет_одеждыEntities = new Складской_учет_одеждыEntities();
            WindowState = WindowState.Maximized;
            Entities_Sklad_tovar = new Entities_Sklad_tovar();
            DtGrdTovari.ItemsSource = Entities_Sklad_tovar.товары.ToList();
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

        //private Складской_учет_одеждыEntities Складской_учет_одеждыEntities;
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



        //переход на окно Добавить товар
        private void LabelDobavNewTovar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DobavTovar Glavnaya = new DobavTovar();
            Glavnaya.Show();
            this.Close();
        }

        //private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    DtGrdTovari.ItemsSource = database.товары.Where(k =>
        //          k.ID_товара.ToString().Contains(TBSearch.Text)
        //       || k.артикул.ToString().Contains(TBSearch.Text)
        //       || k.наименование_товара.ToString().Contains(TBSearch.Text)
        //       || k.цена.ToString().Contains(TBSearch.Text)
        //       || k.описание.ToString().Contains(TBSearch.Text)
        //       || k.состав.ToString().Contains(TBSearch.Text)
        //       || k.фото.ToString().Contains(TBSearch.Text));

        //    DtGrdTovari.ItemsSource = database.категория_товара.Where(d =>
        //           d.наименование.ToString().Contains(TBSearch.Text));

        //    DtGrdTovari.ItemsSource = database.пол.Where(g =>
        //           g.наименование.ToString().Contains(TBSearch.Text));

        //    DtGrdTovari.ItemsSource = database.цвет.Where(l =>
        //           l.наименование.ToString().Contains(TBSearch.Text));

        //    DtGrdTovari.ItemsSource = database.размеры.Where(b =>
        //           b.европейский.ToString().Contains(TBSearch.Text)
        //        || b.российский.ToString().Contains(TBSearch.Text));

        //    if (TBSearch.Text == "")
        //    {
        //        DtGrdTovari.ItemsSource = database.инвентаризация_склада.ToList();
        //    }
        //}


        //private void TBSearch_TextChanged(object sender, RoutedEventArgs e)
        //{
        //    DtGrdTovari.ItemsSource = cont.Users.Where(k => k.LastName.ToString().Contains(TxtBxSearch.Text)
        //        || k.UserName.ToString().Contains(TxtBxSearch.Text)
        //        || k.Partronymic.ToString().Contains(TxtBxSearch.Text)
        //        || k.loginUs.ToString().Contains(TxtBxSearch.Text)).ToList();


        //    if (TxtBxSearch.Text == "")
        //    {
        //        DtGrdUser.ItemsSource = cont.Users.ToList();
        //    }
        //}

    }
}
