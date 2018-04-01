using System.ComponentModel;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.ComboBox;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ComboBox), typeof(ComboBoxRenderer))]
namespace Xamarin.Forms.ComboBox
{
    public class ComboBoxRenderer : ViewRenderer<ComboBox, Windows.UI.Xaml.Controls.ComboBox>
    {
        #region Fields
        private bool _isDisposed;
        #endregion

        public ComboBoxRenderer()
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ComboBox> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    var comboBox = CreateNativeControl();

                    comboBox.BorderThickness = new Windows.UI.Xaml.Thickness(1);
                    comboBox.BorderBrush = new SolidColorBrush(Colors.Red);

                    comboBox.SelectionChanged += ComboBox_SelectionChanged;
                    var items = e.NewElement.ItemsSource;
                    comboBox.ItemsSource = e.NewElement.ItemsSource;
                    SetNativeControl(comboBox);
                    Element.SelectedIndexChanged += Element_SelectedIndexChanged;
                    UpdateSelectedIndex();
                    UpdateTextColor();
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            UpdateSelectedItem();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Picker.SelectedIndexProperty.PropertyName)
            {
                UpdateSelectedIndex();
            }
            else if (e.PropertyName == Picker.TextColorProperty.PropertyName)
            {
                UpdateTextColor();
            }

            base.OnElementPropertyChanged(sender, e);
        }

        private void Element_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateSelectedIndex();
        }

        private void UpdateSelectedIndex()
        {
            var index = Element.SelectedIndex;
            
            if (Control.SelectedIndex != index)
            {
                Control.SelectedIndex = index;
            }
        }

        private void UpdateSelectedItem()
        {
            if (Element.SelectedIndex != Control.SelectedIndex)
            {
                Element.SelectedIndex = Control.SelectedIndex;
            }
        }
        private void UpdateTextColor()
        {
            Control.Foreground = Element.TextColor.ToBrush();
        }

        protected Windows.UI.Xaml.Controls.ComboBox CreateNativeControl()
        {
            return new Windows.UI.Xaml.Controls.ComboBox();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && !_isDisposed)
            {
                _isDisposed = true;
            }

            base.Dispose(disposing);
        }
    }
}
