using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SimpleInterestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void Button_Clicked(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(principleAmount.Text)  * Convert.ToDouble(months.Text) * Convert.ToDouble(intrest.Text) / 100;
            Atotal.Text = total.ToString();

        }
    }
}
