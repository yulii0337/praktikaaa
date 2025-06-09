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
    /// Логика взаимодействия для DobavTovar.xaml
    /// </summary>
    public partial class DobavTovar : Window
    {
        public DobavTovar()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

        //добавить
        private void RegistrBttn_Click(object sender, RoutedEventArgs e)
        {
            Tovari DobavTovar = new Tovari();
            DobavTovar.Show();
            this.Close();
        }

        //назад


        private void NazadBttn_Click_1(object sender, RoutedEventArgs e)
        {
            Tovari DobavTovar = new Tovari();
            DobavTovar.Show();
            this.Close();
        }
    }
}
