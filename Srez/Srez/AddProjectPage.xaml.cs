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
    public partial class AddProjectPage : ContentPage
    {
        public DateTime Today { get; set; }
        public AddProjectPage()
        {
            InitializeComponent();
            Today = DateTime.Today;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            App.Database.SaveProject(new Model.Project
            {
                Name = entryName.Text,
                User_id = Core.CurrentUser.id
            });
            await Navigation.PopAsync();
        }
    }
}