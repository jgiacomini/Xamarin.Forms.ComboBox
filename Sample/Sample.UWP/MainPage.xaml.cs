using Windows.UI.Xaml.Controls;

namespace Sample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Sample.App());
        }

    }
}
