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
using System.Windows.Shapes;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Glavnaya.xaml
    /// </summary>
    public partial class Glavnaya : Window
    {
        public Glavnaya()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

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
