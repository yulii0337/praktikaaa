using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Inventarizatsiya.xaml
    /// </summary>
    public partial class Inventarizatsiya : Window
    {
        Entities_Sklad_tovar database = new Entities_Sklad_tovar();

        int selectRow;



        public Inventarizatsiya()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            Entities_Sklad_tovar = new Entities_Sklad_tovar();
            DtGrdInventariz.ItemsSource = Entities_Sklad_tovar.инвентаризация_склада.ToList();

            // Загрузите данные в локальную коллекцию
            //_inventarizationList = new ObservableCollection<инвентаризация_склада>(database.инвентаризация_склада.ToList());
            // Привязка к DataGrid
            // DtGrdInventariz.ItemsSource = _inventarizationList;
            // Загрузите данные в локальную коллекцию
            //SotrudList = new ObservableCollection<сотрудник>(database.сотрудник.ToList());
            // Привязка к DataGrid
            // DtGrdInventariz.ItemsSource = SotrudList;
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

        //переход на окно Добавить инвентаризацию
        private void LabelDobavNewTovar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NewInventariz Glavnaya = new NewInventariz();
            Glavnaya.Show();
            this.Close();
            //var WinAdd = new категория_товара();
            //Entities_Sklad_tovar.категория_товара.Add(WinAdd);
            //var win = new NewInventariz(Entities_Sklad_tovar, WinAdd);
            //win.ShowDialog();
            //DtGrdInventariz.ItemsSource = Entities_Sklad_tovar.категория_товара.ToList();
            //this.Close();

        }

        private Entities_Sklad_tovar GetDatabase()
        {
            return database;
        }

        private void TBSearch_TextChanged(object sender, RoutedEventArgs e)
        {


            DtGrdInventariz.ItemsSource = database.инвентаризация_склада.Where(k =>
                   k.дата_инвентаризации.ToString().Contains(TBSearch.Text)
                || k.ID_инвентаризация_склада.ToString().Contains(TBSearch.Text)
                || k.расчетный_остаток.ToString().Contains(TBSearch.Text)
                || k.фактический_остаток.ToString().Contains(TBSearch.Text));

            DtGrdInventariz.ItemsSource = database.склад.Where(d =>
                   d.ID_склада.ToString().Contains(TBSearch.Text));

            DtGrdInventariz.ItemsSource = database.товары.Where(g =>
                   g.ID_товара.ToString().Contains(TBSearch.Text));

            DtGrdInventariz.ItemsSource = database.сотрудник.Where(b =>
                   b.фамилия.ToString().Contains(TBSearch.Text)
                || b.имя.ToString().Contains(TBSearch.Text)
                || b.отчество.ToString().Contains(TBSearch.Text));

            if (TBSearch.Text == "")
            {
                DtGrdInventariz.ItemsSource = database.инвентаризация_склада.ToList();
            }
        }


        //    private ObservableCollection<инвентаризация_склада> _inventarizationList;
        //    private ObservableCollection<сотрудник> SotrudList;

        //    private void TBSearch_TextChanged(object sender, RoutedEventArgs e)
        //    {
        //        var searchText = TBSearch.Text.ToLower();

        //        var filteredResults = _inventarizationList
        //            .Where(k => k.дата_инвентаризации.ToString().ToLower().Contains(searchText) ||
        //                         k.ID_инвентаризация_склада.ToString().ToLower().Contains(searchText) ||
        //                         k.расчетный_остаток.ToString().ToLower().Contains(searchText) ||
        //                         k.фактический_остаток.ToString().ToLower().Contains(searchText))
        //            .ToList();

        //        // Установите источник данных для DataGrid
        //        DtGrdInventariz.ItemsSource = filteredResults;

        //        var w = SotrudList
        //.Where(в => в.имя.ToString().ToLower().Contains(searchText) ||
        //             в.отчество.ToString().ToLower().Contains(searchText) ||
        //              в.фамилия.ToString().ToLower().Contains(searchText))
        //.ToList();

        //        // Установите источник данных для DataGrid
        //        DtGrdInventariz.ItemsSource =  w;
        //    }



    }
}
