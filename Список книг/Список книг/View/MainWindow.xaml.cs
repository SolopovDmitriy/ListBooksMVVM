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
using Список_книг.models;
using Список_книг.ViewModel;
namespace Список_книг
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        private ListBooksWindow _listBooksWindow;
        public MainWindow()
        {
            _viewModel = new MainViewModel();
            InitializeComponent();
        }
        private void Button_AddBook(object sender, RoutedEventArgs e)
        {
            _viewModel.Library.Books.Add(new Book(TextBox_Title.Text, TextBox_Author.Text, ""));
            
            TextBox_Title.Text = "";
            TextBox_Author.Text = "";
        }
        private void Button_ShowBooks(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_listBooksWindow == null)
                {
                    _listBooksWindow = new ListBooksWindow(_viewModel);
                }
                _listBooksWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_ShowBook(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(_listBooksWindow != null)
            {
                _listBooksWindow.Close();
            }
            e.Cancel = false;
        }
    }
}
