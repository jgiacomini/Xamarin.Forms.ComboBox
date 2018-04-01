using System;

namespace Xamarin.Forms.ComboBox
{
    public class SelectedIndexChangedEventArgs : EventArgs
    {
        public SelectedIndexChangedEventArgs(int oldIndex, int newIndex)
        {
            OldIndex = oldIndex;
            NewIndex = newIndex;
        }
        public int OldIndex { get; set; }
        public int NewIndex { get; set; }
    }
}
