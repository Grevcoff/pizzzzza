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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace piza
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        pizzaEntities1 context;
        public int countPages;
        public int currentPage;
        public int countRecord = 10;

        public MainWindow()
        {
            InitializeComponent();
            context = new pizzaEntities1();
            dgMain.ItemsSource = context.main.Take(countRecord).ToList();
            countPages = context.main.Count() / 10;
            currentPage = 1;
            CurrentPage.Text = currentPage + " из " + countPages;
            CmbFilter.ItemsSource = context.main.ToList();
        }

        private DataTable _dt = new DataTable();
        // Сколько элементов отображается на каждой странице
        private int pageNum = 25;
                 // Какая страница сейчас
        private int pIndex = 1;
                 //Объект
        private DataGrid grdList;
                 // Максимальное количество страниц
        private int MaxIndex = 1;
                 // Сколько всего
        private int allNum = 0;
 
                 #region Инициализировать данные
        /// <summary>
                 /// Данные инициализации
        /// </summary>
        /// <param name="grd"></param>
        /// <param name="dtt"></param>
        /// <param name="Num"></param>
        public void ShowPages(DataGrid grd, DataTable dt)

        private void AddData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSortFirstName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSortLastDate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSortCount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbSelectCount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void showRecord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PrevPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void AddData_Click(object sender, RoutedEventArgs e)
        //{


        //}

        //private void DeleteData_Click(object sender, RoutedEventArgs e)
        //{

        //}
        //public List<Client> clients;
        //private void ShowTable()
        //{
        //    if (CmbFilter.SelectedItem == null)
        //        return;

        //    var gender = CmbFilter.SelectedItem as main;
        //    clients = context.Clients.ToList();
        //    if (cmbSelectCount.SelectedIndex == 3)
        //    {
        //        clients = context.Clients.ToList();
        //        countPages = 1;
        //    }

        //    if (txtEmail.Text != "")
        //    {
        //        clients = clients.Where(x => x.Email.Contains(txtEmail.Text)).ToList();
        //    }
        //    if (txtPhone.Text != "")
        //    {
        //        clients = clients.Where(x => x.Phone.Contains(txtPhone.Text)).ToList();
        //    }
        //    if (txtName.Text != "")
        //    {
        //        clients = clients.Where(x => x.FirstName.ToLower().Contains(txtName.Text.ToLower())
        //                                    || x.LastName.ToLower().Contains(txtName.Text.ToLower())
        //                                    || x.Patronymic.ToLower().Contains(txtName.Text.ToLower())).ToList();
        //    }
        //    clients = clients.Where(x => x.Gender.Code == gender.Code).OrderBy(x => x.ID).Skip(currentPage * countRecord - countRecord).Take(countRecord).ToList();
        //    countPages = context.Clients.Where(x => x.Gender.Code == gender.Code).Count() / countRecord;

        //    setEnableButtons();
        //    CurrentPage.Text = currentPage + " из " + countPages;
        //    dgClients.ItemsSource = clients;
        //}

        //private void cmbSelectCount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    currentPage = 1;
        //    ClientServiceEntities context2 = new ClientServiceEntities();

        //    switch (cmbSelectCount.SelectedIndex)
        //    {
        //        case 0:
        //            countRecord = 10;

        //            break;
        //        case 1:
        //            countRecord = 50;

        //            break;
        //        case 2:

        //            countRecord = 200;
        //            break;
        //        default:
        //            countRecord = context2.Clients.Count();
        //            countPages = 1;
        //            break;
        //    }
        //}

        //private void PrevPage_Click(object sender, RoutedEventArgs e)
        //{

        //    if (currentPage > 1 && currentPage <= countPages)
        //    {
        //        currentPage--;
        //        ShowTable();
        //        NextPage.IsEnabled = true;
        //        if (currentPage == 1)
        //        {
        //            PrevPage.IsEnabled = false;
        //        }

        //    }
        //}

        //private void NextPage_Click(object sender, RoutedEventArgs e)
        //{
        //    if (currentPage < countPages)
        //    {

        //        currentPage++;
        //        ShowTable();
        //        PrevPage.IsEnabled = true;
        //        if (currentPage == countPages)
        //        {
        //            NextPage.IsEnabled = false;
        //        }
        //    }

        //}

        //private void setEnableButtons()
        //{
        //    if (countPages == 1 || countPages == 0)
        //    {
        //        PrevPage.IsEnabled = false;
        //        NextPage.IsEnabled = false;
        //        countPages = 1;
        //    }
        //    else
        //    {
        //        PrevPage.IsEnabled = true;
        //        NextPage.IsEnabled = true;
        //    }


        //}
        //private void showRecord_Click(object sender, RoutedEventArgs e)
        //{
        //    setEnableButtons();
        //    ShowTable();
        //}

        //private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    currentPage = 1;
        //    ShowTable();
        //}

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    ShowTable();
        //}

        //private void BtnSortFirstName_Click(object sender, RoutedEventArgs e)
        //{
        //    dgClients.ItemsSource = clients.OrderBy(x => x.FirstName).ToList();
        //}

        //private void BtnSortLastDate_Click(object sender, RoutedEventArgs e)
        //{

        //    dgClients.Items.SortDescriptions.Clear();
        //    dgClients.Items.SortDescriptions.Add(new SortDescription("lastDate", ListSortDirection.Descending));
        //    dgClients.Items.Refresh();
        //}

        //private void BtnSortCount_Click(object sender, RoutedEventArgs e)
        //{
        //    dgClients.Items.SortDescriptions.Clear();
        //    dgClients.Items.SortDescriptions.Add(new SortDescription("countVisit", ListSortDirection.Descending));
        //    dgClients.Items.Refresh();



        //}
    }
}
