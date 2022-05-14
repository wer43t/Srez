
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e)
        {
            if(Core.TryLogin(entryLogin.Text, entryPassword.Text))
            {
                await Navigation.PushAsync(new ProjectsPage());
            }
        }
    }
}