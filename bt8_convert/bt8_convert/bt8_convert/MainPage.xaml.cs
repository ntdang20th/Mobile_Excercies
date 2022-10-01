using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bt8_convert
{
    public partial class MainPage : ContentPage
    {
        private double _cel;
        private double _fah;

        public double Cel { get => _cel; set => _cel = value; }
        public double Fah { get => _fah; set => _fah = value; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            
        }

        private void btnToCel_Clicked(object sender, EventArgs e)
        {
            Cel = (Fah - 32) * 5 / 9;
            entryCel.Text = String.Format("{0}°C", Math.Round(Cel, 2));
            entryFah.Text = String.Format("{0}°F", Math.Round(Fah, 2));
        }

        private void btnToFah_Clicked(object sender, EventArgs e)
        {
            Fah = Cel * 9 / 5 +32;
            entryCel.Text = String.Format("{0}°C", Cel);
            entryFah.Text = String.Format("{0}°F", Fah);
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            entryCel.Text = entryFah.Text = String.Empty;
        }

        private void entryCel_Focused(object sender, FocusEventArgs e)
        {
            entryCel.Text = "";
        }

        private void entryFah_Focused(object sender, FocusEventArgs e)
        {
            entryFah.Text = "";
        }

    }
}
