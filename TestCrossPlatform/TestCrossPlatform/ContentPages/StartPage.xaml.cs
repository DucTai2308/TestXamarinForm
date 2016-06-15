using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestCrossPlatform.ContentPages
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        public void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage());
        }
        public void ShowTilteButton_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TiltePage());
        }
        public void ShowScheduleButton_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulePage());
        }

    }
}
