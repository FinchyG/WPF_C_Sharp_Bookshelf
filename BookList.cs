using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Bookshelf
{
    public class BookList : INotifyPropertyChanged
    {
        string _title = "";
        string _author = "";
        string _selectedName;

        public BookList()
        {
            Names = new ObservableCollection<string>();
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (_author != value)
                {
                    _author = value;
                    OnPropertyChanged("Author");
                }
            }
        }

        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    OnPropertyChanged("SelectedName");
                }
            }
        }

        public ObservableCollection<string> Names { get; private set; }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        AddCommand _addNameCommand = new AddCommand();

        public AddCommand AddNameCommand
        {
            get { return _addNameCommand; }
        }

        RemoveCommand _removeNameCommand = new RemoveCommand();

        public RemoveCommand RemoveNameCommand
        {
            get { return _removeNameCommand; }
        }
    }
}
