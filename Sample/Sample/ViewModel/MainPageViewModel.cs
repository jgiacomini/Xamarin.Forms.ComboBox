using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sample.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _selectedIndex;
        private string _selectedItem;
        private Color _textColor = Color.Red;

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
            ChangeTextColorCommand = new Command(ChangeColor);
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

        public Color TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                if(_textColor != value)
                {
                    _textColor = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextColor)));
                }
            }
        }

        public ICommand ChangeTextColorCommand
        {
            get;
        }

        void ChangeColor()
        {
            if (TextColor == Color.Red)
            {
                TextColor = Color.Pink;
            }
            else
            {
                TextColor = Color.Red;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
