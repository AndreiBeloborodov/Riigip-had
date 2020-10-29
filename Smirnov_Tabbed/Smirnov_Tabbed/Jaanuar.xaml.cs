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
    public partial class Jaanuar : ContentPage
    {
        //BoxView box;
        Label picture1;
        public Jaanuar()
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
            Label nimetus = new Label { Text = "Jaanuari pilt", FontSize = 30 };
            Image img = new Image { Source = "Jaanuar.jpg" };
            Label kirjeldus = new Label { Text = "Uusaasta on püha, mil tähistatakse uue kalendriaasta algust. Lääneriikides, kus kasutatakse Gregoriuse kalendrit, on uusaasta 1. jaanuaril." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                picture1 = (Label)s;
                await DisplayAlert("Доп. инфо", "Uusaasta on püha, mil tähistatakse uue kalendriaasta algust.Lääneriikides, kus kasutatakse Gregoriuse kalendrit, on uusaasta 1.jaanuaril.", "закрыть");
            };
            picture1.GestureRecognizers.Add(tap1);
        }
    }
}