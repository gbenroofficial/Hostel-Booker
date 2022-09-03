using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupProject
{
    public partial class App : Application
    {
        Login loginCopy = new Login();
        public App()
        {
            InitializeComponent();      
            
            MainPage = new NavigationPage(new loginPage(loginCopy));
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
