using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Bookshelf
{
    public class InfoCommand : ICommand
    {
        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, World!");
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
