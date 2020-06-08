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
            var nameList = parameter as BookList;
            return nameList != null && nameList.SelectedName != null;
        }

        public void Execute(object parameter)
        {
            var nameList = parameter as BookList;
            var oldName = nameList.SelectedName;
            nameList.Names.Remove(oldName);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
