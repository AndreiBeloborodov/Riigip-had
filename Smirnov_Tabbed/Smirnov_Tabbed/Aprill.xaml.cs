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
    public partial class Aprill : ContentPage
    {
        //BoxView box;
        Label picture4;
        public Aprill()
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
            Label nimetus = new Label { Text = "Aprill", FontSize = 30 };
            Image img = new Image { Source = "Aprill.jpg" };
            Label kirjeldus = new Label { Text = "Suur reede on kristlik püha, mil tähistatakse Jeesus Kristuse ristilöömist ja surma Kolgata mäel. See kuulub kokku rea teiste pühadega, mis seostuvad Jeesuse eluga. Suur reede eelneb lihavõttepühadele ning võib langeda kokku juudiusu paasapühadega." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Доп. инфо", "Suur reede on kristlik püha, mil tähistatakse Jeesus Kristuse ristilöömist ja surma Kolgata mäel. See kuulub kokku rea teiste pühadega, mis seostuvad Jeesuse eluga. Suur reede eelneb lihavõttepühadele ning võib langeda kokku juudiusu paasapühadega.", "закрыть");
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