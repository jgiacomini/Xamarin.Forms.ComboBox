using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;
using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.ComboBox;
using AColor = Android.Graphics.Color;
using AView = Android.Views.View;

[assembly: ExportRenderer(typeof(ComboBox), typeof(ComboBoxRenderer))]
namespace Xamarin.Forms.ComboBox
{
    public class FormsSpinnerAdapter : BaseAdapter
    {
        private readonly IList _items;
        private AColor _textColor;
        public FormsSpinnerAdapter(Context context, IList items, AColor textColor) 
        {
            _items = items;
            _textColor = textColor;
            Context = context;
        }

        public Context Context { get; private set; }

        public AColor TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                if (_textColor != value)
                {
                    _textColor = value;
                    // Redraw all cells
                    NotifyDataSetChanged();
                }
            }
        }

        public override int Count => _items.Count;

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override AView GetView(int position, AView convertView, ViewGroup parent)
        {
            TextView view = new TextView(Context);

            // view.SetBackgroundColor(bgColor);
            view.SetTextColor(_textColor);
            // view.SetTypeface(Typeface.Monospace, TypefaceStyle.Bold);
            view.SetHeight(50);

            view.Text = _items[position].ToString();


            return view;
            //var dataTemplate = new DataTemplate(() =>
            //{
            //    var viewHolder = new ContentView();
            //    viewHolder.HorizontalOptions = LayoutOptions.Fill;
            //    viewHolder.VerticalOptions = LayoutOptions.Start;
            //    viewHolder.HeightRequest = 20;
            //    viewHolder.BackgroundColor = Color.Green;

            //    var grid = new Grid();
            //    grid.BackgroundColor = Color.Red;
            //    var label = new Label { FontAttributes = FontAttributes.Bold };

            //    //label.SetBinding(Label.TextProperty, "Name");
            //    label.Text = "lol";
            //    label.HeightRequest = 20;
            //    grid.Children.Add(label);

            //    viewHolder.Content = grid;
            //    return viewHolder;
            //});
            
            //var view = dataTemplate.CreateContent() as VisualElement;
            //var renderer = Xamarin.Forms.Platform.Android.Platform.CreateRendererWithContext(view, Context);
            //Xamarin.Forms.Platform.Android.Platform.SetRenderer(view, renderer);
            
            //renderer.Element.Layout(new Rectangle(0, 0, 200, 50));
            //renderer.UpdateLayout();
            //var nativeView = renderer.View;
            //return renderer.View;
        }
    }
}
