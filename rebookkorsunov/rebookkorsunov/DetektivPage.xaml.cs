using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rebookkorsunov
{
    public partial class DetektivPage
    {
        public DetektivPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_LoeTenj(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ktotenjPage());
        }

        private async void Button_Clicked_Apel(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new apelPage());
        }
    }
}