using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Список_книг.models
{
   public class Library
    {
        private ObservableCollection<Book> _books;
        public Library()
        {
            _books = new ObservableCollection<Book>();
        }
        public ObservableCollection<Book> Books
        {
           get { return _books; }
        }
    }
}
