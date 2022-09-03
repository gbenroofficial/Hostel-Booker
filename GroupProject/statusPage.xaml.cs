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
    public partial class statusPage : ContentPage
    {
        RoomsCollection roomsCopy = new RoomsCollection(); //create a list for storing passed list
        public statusPage(RoomsCollection rooms)
        {
            InitializeComponent();
            roomsCopy = rooms;
            payListV.ItemsSource = roomsCopy.RoomList; //copy passed list into created list to use on this page
        }

        
         
        private async void deleteButton_Clicked(object sender, EventArgs e)
        {
            var stuff = (Xamarin.Forms.Button)sender;
            Room listitem = (from itm in roomsCopy.RoomList
                             where itm.RmName == stuff.CommandParameter.ToString()// matches the selected item(bound to item name in class to item name in source list
                             select itm).FirstOrDefault<Room>(); //select the item in list

            roomsCopy.RoomList.Remove(listitem); //remove room from observable collection
            

            if (roomsCopy.RoomList.Count == 0) //if page is empty (observable list is empty)
            {
                await Navigation.PopAsync(); //pop page out of stack
            }
        }

        private async void payButton_Clicked(object sender, EventArgs e)
        {
            var stuff = (Xamarin.Forms.Button)sender;
            Room listitem = (from itm in roomsCopy.RoomList
                             where itm.RmName == stuff.CommandParameter.ToString() // matches the selected item(bound to item name in class to item name in source list
                             select itm).FirstOrDefault<Room>(); //select first item match in list

            if (listitem.Count > 0) {
                var response = await DisplayAlert("", "Please confirm payment", "Confirm", "Cancel");

                if (response)
                {
                    await DisplayAlert("", "Payment has been confirmed", "Ok");
                    listitem.Count -= 1;
                    roomsCopy.RoomList.Remove(listitem); //remove item from list/page

                    if (roomsCopy.RoomList.Count == 0) //if page is empty (observable list is empty)
                    {
                        await Navigation.PopAsync(); //pop page out of stack
                    }
                }
            }

            else
            {
                await DisplayAlert("", "Room has become unavailable", "Ok");
                roomsCopy.RoomList.Remove(listitem);
                if (roomsCopy.RoomList.Count == 0) //if page is empty (observable list is empty)
                {
                    await Navigation.PopAsync(); //pop page out of stack
                }

            }
            

        }
    }
}