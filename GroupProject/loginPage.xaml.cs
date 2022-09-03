using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loginPage : ContentPage
    {
        Login loginCopy = new Login(); //Login class object created
        public loginPage(Login login)
        {
            InitializeComponent();
            loginCopy = login; //copies object passed from register page (for new user info). 
            
        }
        
        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (username.Text == loginCopy.Username && password.Text == loginCopy.Password) //ensures correctness of login credentials
            {
                
                await Navigation.PushAsync(new ApplyPage()); //pushes Apply page unto stack
                this.Navigation.RemovePage(this.Navigation.NavigationStack[0]); //removes page from stack after login
            }
            else
            {
                await DisplayAlert("Login failed!", "Wrong username or  password entered", "Ok"); //error display if incorrect credential for login entered
                
            }
        }

        private async void newUserButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage()); //stacks register page for new users
        }
    }
}