using System;
using Xamarin.Forms;

namespace XFSharedLibraryApp
{
    public class SimpleContentPage : ContentPage
    {
        public SimpleContentPage()
        {
            var label1 = new Label
            {
                Text = "This is my label",
                Font = Font.BoldSystemFontOfSize(NamedSize.Large)
            };

            var entry1 = new Entry
            {
                Placeholder = "Type something here"
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = {
                    label1,
                    entry1
                }
            };
        }
    }
}
