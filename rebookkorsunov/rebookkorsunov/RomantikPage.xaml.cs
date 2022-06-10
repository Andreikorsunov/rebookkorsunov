using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rebookkorsunov
{
    public partial class RomantikPage
    {
        public RomantikPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_LoeVanil(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VanilPage());
        }
    }
}