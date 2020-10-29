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
    public partial class Märts : ContentPage
    {
        //BoxView box;
        Label picture3;
        public Märts()
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
            Label nimetus = new Label { Text = "Märts", FontSize = 30 };
            Image img = new Image { Source = "Mart.jpg" };
            Label kirjeldus = new Label { Text = "emakeelepäev" };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                picture3 = (Label)s;
                await DisplayAlert("Доп. инфо", "emakeelepäev", "закрыть");
            };
            picture3.GestureRecognizers.Add(tap1);
        }
    }
}