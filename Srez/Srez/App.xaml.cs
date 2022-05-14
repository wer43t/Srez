using System;
using System.IO;
using Xamarin.Forms;

namespace Srez
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        public static ProjectsRepository database;
        public static ProjectsRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProjectsRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
