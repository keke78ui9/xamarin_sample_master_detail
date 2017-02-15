using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailExample1
{
    public partial class MyTabbedPages : TabbedPage
    {
        public MyTabbedPages()
        {
            InitializeComponent();

            var page1 = new NavigationPage(new Page1());
            page1.Icon = "block.png";
            page1.Title = "Page4";

            var page5 = new NavigationPage(new Page5());
            page5.Icon = "book.png";
            page5.Title = "Page5";

            var page6 = new NavigationPage(new Page6());
            page6.Icon = "alarmclock.png";
            page6.Title = "Page6";

            var page7 = new NavigationPage(new Page7());
            page7.Icon = "dglasses.png";
            page7.Title = "Page7";

            Children.Add(page1);
            Children.Add(page5);
            Children.Add(page6);
            Children.Add(page7);
        }
    }
}
