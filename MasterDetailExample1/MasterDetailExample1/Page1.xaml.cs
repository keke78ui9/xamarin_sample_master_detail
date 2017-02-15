using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailExample1
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Test1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Test2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page4());
        }

        private void Test3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());

        }

    }
}
