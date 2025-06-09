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
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using System.Xml.Linq;
namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для NewInventariz.xaml
    /// </summary>
    public partial class NewInventariz 
    {

        Entities_Sklad_tovar database = new Entities_Sklad_tovar();

        public NewInventariz(/*Entities_Sklad_tovar Entities_Sklad_tovar, категория_товара pr*/)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            Entities_Sklad_tovar = new Entities_Sklad_tovar();

            //CmbBoxKategoria.ItemsSource = Entities_Sklad_tovar.категория_товара.ToList();
            //Entities_Sklad_tovar = new Entities_Sklad_tovar();

            //CmbBoxKategoria.ItemsSource = Entities_Sklad_tovar.категория_товара.ToList();


            //foreach (var v in Entities_Sklad_tovar.категория_товара.ToList())
            //{
            //    CmbBoxKategoria.Items.Add(v.наименование.ToString());
            //}
            //this.DataContext = pr;
        
    }

        public System.Data.DataTable Select(string selectSQL)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlConnection sqlConnection = new SqlConnection(@"data source=DESKTOP-M6BHTCC;initial catalog=Складской_учет_одежды;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        private Entities_Sklad_tovar Entities_Sklad_tovar;




        //добавить
        private void RegistrBttn_Click(object sender, RoutedEventArgs e)
        {
            Inventarizatsiya NewInventariz = new Inventarizatsiya();
            NewInventariz.Show();
            this.Close();
        }

        //назад


        private void NazadBttn_Click_1(object sender, RoutedEventArgs e)
        {
            Inventarizatsiya NewInventariz = new Inventarizatsiya();
            NewInventariz.Show();
            this.Close();
        }

        private void SozdatOtchetBttn_Click(object sender, RoutedEventArgs e)
        {
            //Основная информация
            string textToExport = TxtBoxArticul.Text;

            //Наименование
            string textToExport1 = TxtBoxName.Text;

            //Категория
            string textToExport2 = CmbBoxKategoria.Text;

            //Пол
            string textToExport3 = CmbBoxPol.Text;

            //Размер
            string textToExport4 = CmbBoxSize.Text;

            //Цвет
            string textToExport5 = CmbBoxColor.Text;

            //Цена
            string textToExport6 = TxtBoxPrice.Text;

            //Поставщик
            string textToExport7 = CmbBoxPostavka.Text;

            //Описание
            string textToExport8 = TxtBoxOpisanie.Text;

            //Состав
            string textToExport9 = TxtBoxSostav.Text;

           

            if (string.IsNullOrEmpty(textToExport))
            {
                MessageBox.Show("Введите текст для экспорта", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            try
            {
                Application wordApp = new Application();
                Document wordDoc = wordApp.Documents.Add();
                wordDoc.Content.Text =
                    $"Основная информация : \n\n " +
                    $"Наименование: {TxtBoxName.Text} " +
                    $"Категория: {CmbBoxKategoria.Text}\n " +
                    $"Пол: {CmbBoxPol.Text}\n " +
                    $"Размер: {CmbBoxSize.Text}\n " +
                    $"Цвет: {CmbBoxColor.Text}\n" +
                    $"Цена: {TxtBoxPrice.Text} \n " +
                    $"Поставщик: {CmbBoxPostavka.Text}\n " +
                    $"Описание: {TxtBoxOpisanie.Text}\n " +
                    $"Состав: {TxtBoxSostav.Text}\n " ;




                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ExportedDocument.docx";

                wordDoc.SaveAs2(filePath);
                wordDoc.Close();
                wordApp.Quit();

                MessageBox.Show($"Документ успешно сохраён: {filePath}", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте в Word: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
    
}
