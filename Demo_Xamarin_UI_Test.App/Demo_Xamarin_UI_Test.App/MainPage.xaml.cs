using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_Xamarin_UI_Test.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSomar_Clicked(object sender, EventArgs e)
        {
            var valorUm = Convert.ToInt16(txtValorUm.Text);
            var valorDois = Convert.ToInt16(txtValorDois.Text);
            var result = valorUm + valorDois;
            lblResultado.Text = result.ToString();
        }
    }
}
