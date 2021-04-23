using System;
using System.Collections;
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
using Список_книг.View;
using Список_книг.ViewModel;

namespace Список_книг
{
    /// <summary>
    /// Логика взаимодействия для ListBooksWindow.xaml
    /// </summary>
    public partial class ListBooksWindow : Window
    {
        private MainViewModel _viewModel;
        public Book selectedBook;

        public ListBooksWindow(MainViewModel viewModel)
        {
            this._viewModel = viewModel;
            InitializeComponent();
            foreach (var item in viewModel.Library.Books)
            {
                ListBoxBooks.Items.Add(item);
            }
            _viewModel.Library.Books.CollectionChanged += Books_CollectionChanged;
        }

        private void Books_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    ListBoxBooks.Items.Add(e.NewItems[0] as Book);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    ListBoxBooks.Items.Remove(e.OldItems[0] as Book);// второй способ через событие
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    ListBoxBooks.Items.Refresh();
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)// my code -------------------------------------
        {      
            selectedBook = (Book)ListBoxBooks.SelectedItem;  //  сохраняем в переменную selectedBook выделенную книгу
            if (selectedBook != null)
            {
                EditWindow editWindow = new EditWindow(this, selectedBook); // создаем окно editWindow      
                editWindow.ShowDialog(); //запуск в режиме модальное окно
            }
            else
            {
                MessageBox.Show("Please, select the book");
            }
          
        }

        public void Refresh()//обновление списка книг на форме
        {
            ListBoxBooks.Items.Refresh();         
        }



        private void Button_Delete_Click(object sender, RoutedEventArgs e) // my code-------------------------------------
        {
            Book book = (Book)ListBoxBooks.SelectedItem; // выделенная книга
            _viewModel.Library.Books.Remove(book); // удаляем книгу из public ObservableCollection<Book> Books
            // 1 способ
           /* ListBoxBooks.Items.Remove(book); */// удаляем из визупльного списка - тот что на форме


            //List<Book> books1 = new List<Book>();
            //ArrayList books2 = new ArrayList();
            //books1.Add(book);
            //books2.Add(book);

            //Book bookGet = books1[0];
            //Book bookGet2 = (Book)books2[0];

            //object book3 = book;
            //string title = ((Book)book3).Title; // old
            //string title2 = (book3 as Book)?.Title; // new



        }
    }
}
