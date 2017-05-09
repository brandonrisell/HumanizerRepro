using System;
using Humanizer;
using Xamarin.Forms;

namespace HumanizerRepro
{
    public partial class HumanizerReproPage : ContentPage
    {
        public HumanizerReproPage()
        {
            InitializeComponent();

            ReproText.Text = DateTime.Now.AddDays(-4).Humanize();
        }
    }
}
