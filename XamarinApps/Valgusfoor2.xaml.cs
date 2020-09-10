using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label RED = new Label()
            {
                Text = "Red",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
            };
            Frame FrameR = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = RED,
                CornerRadius = 90,
                Padding = 40,
                Margin = new Thickness(95, 0, 95, 0)
            };
            Label YELLOW = new Label()
            {
                Text = "Yellow",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
            };
            Frame FrameY = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = YELLOW,
                CornerRadius = 90,
                Padding = 40,
                Margin = new Thickness(95, 0, 95, 0)
            };
            Label GREEN = new Label()
            {
                Text = "Green",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
            };
            Frame FrameG = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = GREEN,
                CornerRadius = 90,
                Padding = 40,
                Margin = new Thickness(95, 0, 95, 0)
            };
            Button on = new Button()
            {
                Text="on",
                BackgroundColor = Color.DarkRed,
            };
            Button off = new Button()
            {
                Text = "off",
                BackgroundColor = Color.DarkRed,
            };
           
            StackLayout stackLayout = new StackLayout()
            {
                Children = { FrameR, FrameY, FrameG, }
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { on, off }
            };

            stackLayout1.Orientation = StackOrientation.Horizontal;
            Content = stackLayout1;
        }
    }
}