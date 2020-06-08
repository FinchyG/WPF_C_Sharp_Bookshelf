using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bookshelf
{
    public class RemoveCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            var bookList = parameter as BookList;
            return bookList != null && bookList.SelectedBook != null;
        }

        public void Execute(object parameter)
        {
            var bookList = parameter as BookList;
            var oldBook = bookList.SelectedBook;
            bookList.Books.Remove(oldBook);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
