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
        public Jaanuar()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLenght(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLenght(3, GridunitType.Star) },
                    new RowDefinition { Height = new GridLenght(2, GridunitType.Star) }
                },
                ColumnDefinitions =
                {
                    new RowDefinition { Width = new GridLenght(1, GridunitType.Star) }
                }
            };
            Label nimetus = new Label { Text = "Jaanuari pilt", FontSize = 30 };
            Image img = new Image { Source = "Январь.jpg" };
            Label kirjeldus = new Label { Text = "Uusaasta on püha, mil tähistatakse uue kalendriaasta algust. Lääneriikides, kus kasutatakse Gregoriuse kalendrit, on uusaasta 1. jaanuaril." };
            grd.children.add(nimetus, 0, 0);
            grd.children.add(img, 0, 1);
            grd.children.add(kirjeldus, 0, 2);
            content = grd;
            {