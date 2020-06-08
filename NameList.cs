using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Bookshelf
{
    public class NameList : INotifyPropertyChanged
    {
        string _firstName = "";
        string _lastName = "";
        string _selectedName;

        public NameList()
        {
            Names = new ObservableCollection<string>();
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
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

        InfoCommand _infoCommand = new InfoCommand();

        public InfoCommand InformationCommand
        {
            get { return _infoCommand; }
        }

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
