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
    public partial class Desember : ContentPage
    {//BoxView box;
        Label picture12;
        public Desember()
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
            Label nimetus = new Label { Text = "Detsember", FontSize = 30 };
            Image img = new Image { Source = "Detsember.jpg" };
            Label kirjeldus = new Label { Text = "Pärast Eesti iseseisvuse taastamist on esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev. Jõulukombestikku mõjutab järjest rohkem rahvusvaheline traditsioon." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Доп. инфо", "Pärast Eesti iseseisvuse taastamist on esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev. Jõulukombestikku mõjutab järjest rohkem rahvusvaheline traditsioon.", "закрыть");
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