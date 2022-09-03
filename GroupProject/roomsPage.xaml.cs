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
    public partial class roomsPage : ContentPage
    {
        List<Room> roomsCopy = new List<Room>(); //create a new List for rooms
        RoomsCollection multipleRooms = new RoomsCollection(); //new observable collection for storing applied rooms
        
        public roomsPage(List<Room> rooms)
        {
            InitializeComponent();
            roomsCopy = rooms; //copies the content of rooms list passed into this page to emptylist roomsCopy
            rmPgLbl.Text = roomsCopy[0].HouseName; //sets label to display general house name

            foreach (Room rm in roomsCopy)
            {
                rm.RmImage = rm.RmImages[0]; //sets initial value of rmImages attribute to first image
            }
            roomListView.ItemsSource = roomsCopy; //sets listview source for rooms to roomsCopy list
            
            
           
        }

        private void prevButton_Clicked(object sender, EventArgs e)
        {            
            var stuff = (Xamarin.Forms.Button)sender;
            Room listitem = (from itm in roomsCopy
                             where itm.RmName == stuff.CommandParameter.ToString()// matches the selected item(bound to item name in class to item name in source list
                             select itm).FirstOrDefault<Room>(); //takes the first appearance


            /* Note: i below is integer attribute in Room object representing position 
            of image in image list (RmImages) with default = 0  */
            if (listitem.i > 0) 
            {
                listitem.i--; 
                listitem.RmImage = listitem.RmImages[listitem.i]; //sets picture to previous item in image list of Rooms object
            }
        }

        private void nextButton_Clicked(object sender, EventArgs e)
        {
            var stuff = (Xamarin.Forms.Button)sender;
            Room listitem = (from itm in roomsCopy
                             where itm.RmName == stuff.CommandParameter.ToString() // matches the selected item(bound to item name in class to item name in source list
                             select itm).FirstOrDefault<Room>();
            
            if (listitem.i < listitem.RmImages.Count - 1)
            {
                listitem.i++; //moves position of image in image list to next
                listitem.RmImage = listitem.RmImages[listitem.i]; //sets image attribute to next image in position i
            }
        }

        private async void applyButton_Clicked(object sender, EventArgs e)
        {
            var stuff = (Xamarin.Forms.Button)sender;
            Room listitem = (from itm in roomsCopy
                             where itm.RmName == stuff.CommandParameter.ToString()// matches the selected item(bound to item name in class to item name in source list
                             select itm).FirstOrDefault<Room>();

            if (listitem.Count > 0) {//if rooms are still available

                if (multipleRooms.RoomList.Contains(listitem))
                {
                    bool response = await DisplayAlert("", "You have already made an application for this room", "Continue", "Cancel");
                    //warns user that option has been applied for previously if the item is already on list


                    if (response)
                    { 
                        
                        multipleRooms.RoomList.Add(listitem); //adds applied room item to list
                        
                    }

                }

                else
                {

                    bool response = await DisplayAlert("Confirmation", "Confirm application for " + listitem.RmName, "Confirm", "Cancel");
                    //if not on the list asks for confirmation

                    if (response)
                    {                        
                                              
                        multipleRooms.RoomList.Add(listitem); //add applied room to list                        
                    }
                }
            }
            else
            {                
                 await DisplayAlert("", "There  are no more rooms available", "Ok");
                   
            }
            

        }

        private async void payPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new statusPage(multipleRooms)); //navigate to payment page along with list of rooms applied for
        }
    }
}