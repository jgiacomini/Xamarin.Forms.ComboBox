using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V7.Widget;
using Xamarin.Forms;
using Xamarin.Forms.ComboBox;
using AColor = Android.Graphics.Color;
using BuildVersionCodes = Android.OS.BuildVersionCodes;
[assembly: ExportRenderer(typeof(ComboBox), typeof(ComboBoxRenderer))]
namespace Xamarin.Forms.ComboBox
{
    public class FormsSpinner : AppCompatSpinner
    {
        public FormsSpinner(Context context) : base(context)
        {
            ChangeArrowColor();
        }

        void ChangeArrowColor()
        {
            this.Background.SetColorFilter(AColor.Red, PorterDuff.Mode.SrcAtop);
            Drawable spinnerDrawable = Background.GetConstantState().NewDrawable();

            spinnerDrawable.SetColorFilter(AColor.Red, PorterDuff.Mode.SrcAtop);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean)
            {
                Background = spinnerDrawable;
            }
            else
            {
                SetBackgroundDrawable(spinnerDrawable);
            }
        }
    }
}
