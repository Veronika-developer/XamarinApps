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
    public partial class RGBmodels : ContentPage
    {
        public RGBmodels()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            if (sender == SliderRED)
            {
                LabelRed.Text = String.Format("Red = {0}", (int)e.NewValue);
            }
            else if (sender == SliderGREEN)
            {
                LabelGreen.Text = String.Format("Green = {0}", (int)e.NewValue);
            }
            else if (sender == SliderBLUE)
            {
                LabelBlue.Text = String.Format("Blue = {0}", (int)e.NewValue);
            }

            FrameColor.BackgroundColor = Color.FromRgb((int)SliderRED.Value,
                                            (int)SliderGREEN.Value,
                                            (int)SliderBLUE.Value);
        }
        Random rnd = new Random();
        private void BtnRnd_Clicked(object sender, EventArgs e)
        {
            int R = rnd.Next(0, 255);//изменение цвета рандомно
            int G = rnd.Next(0, 255);//color
            int B = rnd.Next(0, 255);
            SliderRED.Value = R;
            SliderGREEN.Value = G;
            SliderBLUE.Value = B;
            BtnRnd.BackgroundColor = Color.FromRgb(R, G, B);
            FrameColor.BackgroundColor = Color.FromRgb(R, G, B);
        }

        private void ColorPink_Clicked(object sender, EventArgs e)
        {
            SliderRED.Value = 255;
            SliderGREEN.Value = 192;
            SliderBLUE.Value = 203;
            FrameColor.BackgroundColor = Color.FromRgb(255, 192, 203);
        }
    }
}