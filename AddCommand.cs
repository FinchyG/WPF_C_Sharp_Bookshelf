using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bookshelf
{
    public class AddCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var bookList = parameter as BookList;
            var newBook = string.Format("{0} {1}", bookList.Title, bookList.Author);
            bookList.Books.Add(newBook);
            bookList.Title = bookList.Author = "";
        }

        public bool CanExecute(object parameter)
        {
            var bookList = parameter as BookList;
            return bookList != null
                && !string.IsNullOrWhiteSpace(bookList.Title)
                && !string.IsNullOrWhiteSpace(bookList.Author);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
