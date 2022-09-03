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
    public partial class RegisterPage : ContentPage
    {
        Login loginCopy = new Login(); //create Login class object for storage of entry
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void confirmRegister_Clicked(object sender, EventArgs e)
        {
            
            if (passwordEntry.Text == confirmPasswordEntry.Text) //ensures that password  and confirm password text are same
            {
                loginCopy.Username = usernameEntry.Text; //stores username entry in Login object
                loginCopy.Password = passwordEntry.Text; //stores password entry in Login object
                await Navigation.PushAsync(new loginPage(loginCopy)); //places login page unto stack and passes Login object along
                this.Navigation.RemovePage(this.Navigation.NavigationStack[1]); //removes this page from the stack
            }
            else
            {
                await DisplayAlert("", "Passwords do not match. Please re-enter", "Ok"); //error display if password and confirm password not the same
                passwordEntry.Text = string.Empty; //resets entry to empty
                confirmPasswordEntry.Text = string.Empty; //resets entry to empty
            }
        }

        private async void cancelRegister_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); //pops back into login page
        }
    }
}