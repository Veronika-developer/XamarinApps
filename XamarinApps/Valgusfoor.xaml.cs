using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Layouts_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void on_Clicked(object sender, EventArgs e)
        {
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                FrameR.BackgroundColor = Color.Red;
                FrameY.BackgroundColor = Color.Gray;
                FrameG.BackgroundColor = Color.Gray;
            }
            else if (c == 2)
            {
                FrameR.BackgroundColor = Color.Gray;
                FrameY.BackgroundColor = Color.Yellow;
                FrameG.BackgroundColor = Color.Gray;
            }
            else if (c == 3)
            {
                FrameR.BackgroundColor = Color.Gray;
                FrameY.BackgroundColor = Color.Gray;
                FrameG.BackgroundColor = Color.Green;
            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            FrameR.BackgroundColor = Color.Gray;
            FrameY.BackgroundColor = Color.Gray;
            FrameG.BackgroundColor = Color.Gray;
        }
    }
}