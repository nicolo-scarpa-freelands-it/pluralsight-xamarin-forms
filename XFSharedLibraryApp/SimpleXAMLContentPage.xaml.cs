using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFSharedLibraryApp
{
    public partial class SimpleXAMLContentPage : ContentPage
    {
        public SimpleXAMLContentPage()
        {
            InitializeComponent();

            button.Clicked += (sender, e) => {
                label.Text = "User typed: " + entry.Text;       
            };
        }
    }
}
