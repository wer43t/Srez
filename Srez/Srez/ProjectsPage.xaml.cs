using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Srez.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public List<Project> Projects { get; set; }

        public ProjectsPage()
        {
            InitializeComponent();

            App.Database.DeleteProject(1);
            Projects = App.Database.GetProjects();
            this.BindingContext = this;
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProjectPage());
        }
    }
}