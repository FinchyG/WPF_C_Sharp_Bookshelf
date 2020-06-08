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
            var nameList = parameter as BookList;
            var newName = string.Format("{0} {1}", nameList.Title, nameList.Author);
            nameList.Names.Add(newName);
            nameList.Title = nameList.Author = "";
        }

        public bool CanExecute(object parameter)
        {
            var nameList = parameter as BookList;
            return nameList != null
                && !string.IsNullOrWhiteSpace(nameList.Title)
                && !string.IsNullOrWhiteSpace(nameList.Author);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
