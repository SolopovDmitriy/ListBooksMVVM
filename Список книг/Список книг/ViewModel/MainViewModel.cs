using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Список_книг.models;

namespace Список_книг.ViewModel
{
   public class MainViewModel
    {
        private Library _library;
        private int _cuurentBookIndex = -1;
        private Book _currentBook;
        public MainViewModel()
        {
            _library = new Library();
        }

        public Library Library
        {
            get
            {
                return _library;
            }
        }
        public Book CurrentBook
        {
            get
            {
                return _currentBook;
            }
            private set
            {
                _currentBook = value;
            }
        }

    }
}
