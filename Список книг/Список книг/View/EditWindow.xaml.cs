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
using Список_книг.models;
using Список_книг.ViewModel;

namespace Список_книг.View
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {     
        ListBooksWindow _listBooksWindow;
        Book _selectedBook;

        public EditWindow()
        {
            InitializeComponent();          
        }      

        public EditWindow(ListBooksWindow listBooksWindow, Book selectedBook)
        {
            InitializeComponent();
            _listBooksWindow = listBooksWindow;           
            _selectedBook = selectedBook;          
            TextBox_Author.Text = _selectedBook.Author;
            TextBox_Title.Text = _selectedBook.Title;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {           
            _selectedBook.Author = TextBox_Author.Text;
            _selectedBook.Title = TextBox_Title.Text;
            _listBooksWindow.Refresh();
            //((ListBooksWindow)Owner).Refresh();

        }
    }
}
