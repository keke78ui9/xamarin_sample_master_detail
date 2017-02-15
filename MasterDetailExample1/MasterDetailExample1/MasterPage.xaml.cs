using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailExample1
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                PageName = "Page1",
                Icon = "icon.png",
                PageType = typeof(Page1)
            });
            masterPageItems.Add(new MasterPageItem
            {
                PageName = "Page2",
                Icon = "icon.png",
                PageType = typeof(Page2)
            });
            masterPageItems.Add(new MasterPageItem
            {
                PageName = "Page3",
                Icon = "icon.png",
                PageType = typeof(Page3)
            });
            masterPageItems.Add(new MasterPageItem
            {
                PageName = "TabbedPage",
                Icon = "icon.png",
                PageType = typeof(MyTabbedPages)
            });

            listView.ItemsSource = masterPageItems;

          
        }

       
    }
}
