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
        string _selectedBook;

        public BookList()
        {
            Books = new ObservableCollection<string>();
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

        public string SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                if (_selectedBook != value)
                {
                    _selectedBook = value;
                    OnPropertyChanged("SelectedBook");
                }
            }
        }

        public ObservableCollection<string> Books { get; private set; }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        AddCommand _addBookCommand = new AddCommand();

        public AddCommand AddBookCommand
        {
            get { return _addBookCommand; }
        }

        RemoveCommand _removeBookCommand = new RemoveCommand();

        public RemoveCommand RemoveBookCommand
        {
            get { return _removeBookCommand; }
        }
    }
}
