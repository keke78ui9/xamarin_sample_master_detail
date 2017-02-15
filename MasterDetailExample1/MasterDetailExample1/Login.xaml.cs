using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailExample1
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterDetailExample1.MasterDetailControlPage();
        }
    }
}
