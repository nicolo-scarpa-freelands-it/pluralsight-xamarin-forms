using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFSharedLibraryApp
{
    public partial class SimpleXAMLContentPage : ContentPage
    {
        public SimpleXAMLContentPage()
        {
            InitializeComponent();

            var label = new Label
            {
                Text = "This is my label",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            var entry = new Entry
            {
                Placeholder = "Type something here"
            };

            var button = new Button
            {
                Text = "Click Me!"
            };
            button.Clicked += (sender, e) => {
                label.Text = "User typed: " + entry.Text;
            };

            Content = new StackLayout {
                Padding = 30,
                Spacing = 10,
                Children = {
                    label,
                    entry,
                    button
                }
            };
        }
    }
}
