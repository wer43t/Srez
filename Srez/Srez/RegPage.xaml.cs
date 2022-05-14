using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            App.Database.SaveUser(new Model.User
            {
                FIO = entryFIO.Text,
                Login = entryLogin.Text,
                Password = entryPassword.Text,
                Role = 2,
            });
            await Navigation.PopAsync();
        }
    }
}