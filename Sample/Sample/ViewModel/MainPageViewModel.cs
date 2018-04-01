using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sample.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _selectedIndex;
        private string _selectedItem;

        public MainPageViewModel()
        {
            List = new List<string>()
            {
                "One",
                "Two",
                "Three"
            };

            List2 = new List<string>()
            {
                "One",
                "Two",
                "Three"
            };
            SelectedIndex = 1;
        }

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedIndex)));
                }
            }
        }


        public string SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
                }
            }
        }

        public List<string> List { get; private set; }
        public List<string> List2 { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
