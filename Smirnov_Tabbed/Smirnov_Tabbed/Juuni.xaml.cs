using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Smirnov_Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juuni : ContentPage
    {
        //BoxView box;
        Label picture6;
        public Juuni()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}

                }
            };
            Label nimetus = new Label { Text = "Juuni", FontSize = 30 };
            Image img = new Image { Source = "Juuni.jpg" };
            Label kirjeldus = new Label { Text = "Jaanipäev on Eestis 24. juunil tähistatav püha. 24. juunile eelnevat 23. juuni päeva nimetatakse jaanilaupäevaks ja nendevahelist ööd jaaniööks, seda tähistatakse Eestis, Lätis ja põhjamaades jaanituledega." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Доп. инфо", "Jaanipäev on Eestis 24. juunil tähistatav püha. 24. juunile eelnevat 23. juuni päeva nimetatakse jaanilaupäevaks ja nendevahelist ööd jaaniööks, seda tähistatakse Eestis, Lätis ja põhjamaades jaanituledega.", "закрыть");
                img.Opacity = 0;
            };
            img.GestureRecognizers.Add(tap1);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}