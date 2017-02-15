using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailExample1
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ScrollView scroll = new ScrollView();
            
            StackLayout stackLayout = new StackLayout() {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Button { Text = "button1" });
            stackLayout.Children.Add(new Label { Text = "Label1" });
            stackLayout.Children.Add(new DatePicker { Date = new DateTime(2016, 10, 1) });
            stackLayout.Children.Add(new Editor { Text = "Editor1" });
            stackLayout.Children.Add(new Entry { Text = "Entry1" });
            stackLayout.Children.Add(new Switch { IsToggled = true });
            stackLayout.Children.Add(new TimePicker { Time = new TimeSpan(5, 10, 22) });
            Picker picker = new Picker();
            picker.Items.Add("yo");
            picker.Items.Add("cho");
            picker.Items.Add("mu");
            picker.Items.Add("chi");

            stackLayout.Children.Add(picker);
            scroll.Content = stackLayout;
            this.Content = scroll;
        }
    }
}
