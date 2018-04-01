using Sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.ComboBox;

namespace Sample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = VM = new MainPageViewModel();
        }

        public MainPageViewModel VM { get; private set; }

        private void Index1_Clicked(object sender, EventArgs e)
        {
            VM.SelectedIndex = 0;
        }
        private void Index2_Clicked(object sender, EventArgs e)
        {
            VM.SelectedIndex = 1;
        }

        private void Index3_Clicked(object sender, EventArgs e)
        {
            VM.SelectedIndex = 2;
        }

        private void Item1_Clicked(object sender, EventArgs e)
        {
            VM.SelectedItem = VM.List2[0];
        }
        private void Item2_Clicked(object sender, EventArgs e)
        {
            VM.SelectedItem = VM.List2[1];
        }

        private void Item3_Clicked(object sender, EventArgs e)
        {
            VM.SelectedItem = VM.List2[2];
        }


        private void Combo1_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
        {
            Debug.WriteLine($"Combo1 old index : {e.OldIndex} new index : {e.NewIndex}");
            lbl_combo1.Text = $"Combo1 old index : {e.OldIndex} new index : {e.NewIndex}. Selected Item {_comboBox1.SelectedItem}";
        }
        private void Combo2_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
        {
            Debug.WriteLine($"Combo2 old index : {e.OldIndex} new index : {e.NewIndex}");
            lbl_combo2.Text = $"Combo1 old index : {e.OldIndex} new index : {e.NewIndex}. Selected Item {_comboBox2.SelectedItem}";
        }
    }
}
