using System;

using Xamarin.Forms;

namespace MasterDetailExample1
{
    public partial class MasterDetailControlPage : MasterDetailPage
    {
        public MasterDetailControlPage()
        {
            InitializeComponent();

            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                if (item.PageType == typeof(MyTabbedPages))
                {
                    Detail = new MyTabbedPages();
                }
                else
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
                }
                
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
