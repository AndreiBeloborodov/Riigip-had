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
    public partial class August : ContentPage
    {
        //BoxView box;
        Label picture8;
        public August()
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
            Label nimetus = new Label { Text = "August", FontSize = 30 };
            Image img = new Image { Source = "August.jpg" };
            Label kirjeldus = new Label { Text = "Eesti Vabariigi Ülemnõukogu lähtus oma otsuses Eesti Vabariigi järjekestvusest rahvusvahelise õiguse subjektina." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                picture8 = (Label)s;
                await DisplayAlert("Доп. инфо", "Eesti Vabariigi Ülemnõukogu lähtus oma otsuses Eesti Vabariigi järjekestvusest rahvusvahelise õiguse subjektina.", "закрыть");
            };
            picture8.GestureRecognizers.Add(tap1);
        }
    }
}