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
    public partial class ApplyPage : ContentPage
    {
        public ApplyPage()
        {
            InitializeComponent();
        }

        //The following are image buttons that create automatically a House class object and initializes them.
        private async void caineHouse_Clicked(object sender, EventArgs e)
        {
            House caine = new House();
            caine.HouseName = "Caine House";
            caine.Address = "23 Hunter Street Buckingham MK18 1EG";
            caine.HouseDescribe = "There are 31 rooms.\nStandard rooms (27): These are single standard bedrooms." +
                " There are 2 showers and toilets per 7 students." +
                "\nSelf-contained rooms(4): They have open plan bedroom/kitchen and ensuite facilities. " +
                "They feature double bed and are reserved for postgraduate students." +
                "\n\nAll rooms have wash basins, a mini cool fridge (fridge freezers in self-contained rooms)" +
                " and small vacuum cleaners." +
                "\n\nThere are kitchens on each floor shared by 12 students. Please come along with your own kitchen items" +
                "\n\nAll prices are inclusive of wi-fi and bills.\nCommunal areas are cleaned Monday to Friday.";
            caine.HouseImg = "https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/London%20front.JPG";
             
            await Navigation.PushAsync(new HouseInfoPage(caine)); //each object created is passed as parameter as Houseinfo page is pushed unto stack.
        }

        private async void beloffHouse_Clicked(object sender, EventArgs e)
        {
            House beloff = new House();
            beloff.HouseName = "Beloff House";
            beloff.Address = "22 Hunter street Buckingham MK18 1EG";
            beloff.HouseDescribe = "There are 42 single bedrooms. The top floor is reserved for females only.\n\n" +
                "All rooms have mini-cools, small vacuum cleaners and washbasins." +
                "\n\nThere are 2 showers and toilets per 7 students." +
                "\n\n The kitchens are shared by 14 students. You will need to bring " +
                "your own kitchen items such as pots, crockery, knives and forks.\n\n" +
                "The communal areas are cleaned Monday to Friday.\n\n" +
                "Car parking is at available at Verney Park.\n\n" +
                "These rooms have 4 ft small beds. Please bring your own bedding.\n\n" +
                "The main kitchens are located on the ground floor and are fully equipped " +
                "with cookers, microwaves toasters and kettles. There are 'mini kitchens on the first and second floor ideal for making quick snacks." +
                "Each resident has their own kitchen locker and their own allocated freezer drawer." +
                "Students need to bring their own towels, pots and pans, crockery, knives and forks.\n\n" +
                "The communal areas are cleaned monday to friday.\n\n" +
                "All prices are inclusive of wi-fi and bills.";
            beloff.HouseImg = "https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/IMG_0074.JPG";
            await Navigation.PushAsync(new HouseInfoPage(beloff));
        }     

        private async void mitreHouse_Clicked(object sender, EventArgs e)
        {
            House mitre = new House();
            mitre.HouseName = "Mitre House";
            mitre.Address = "24, Hunter Street, Buckingham, MK18 1EG";
            mitre.HouseDescribe = "The bedrooms vary in size and all rooms have their own small vacuum cleaner\n\n" +
                "Flat 1, 6 and 7 - 2 bedrooms. One room on the ground floor, the other upstairs. Single beds. Shared Kitchen and bedroom.\n\n" +
                "Flats 2 - 2 bedrooms. Ground floor rooms. Single beds. Room 2a also has an additional separate study" +
                "room. Shared kitchen and bathroom.\n\nFlats 3, 4 and 5 - 2 bedrooms. Ground floor rooms.Single beds. Shared bathroom and kitchen." +
                "\n\nFlat 8 - Rooms 8a and 8b - " +
                "2 bedrooms. 1st floor rooms. Single beds.  Room 8a also has an additional separate study room. Shared kitchen and bathroom.\n\n" +
                "Room 8c - is located upstairs in this flat and is a self-contained apartment, with its own bedroom, bathroom and kitchen. " +
                "It features a double bed.\n\n" +
                "Flat 9, 10 and 11 - Located on the 1st floor. 9a, 10a, and 11a are compact self-contained apartments which feature" +
                "an open plan bedroom/kitchen and a bathroom. Due to the restricted space in these rooms, the beds are 'fold-away'" +
                ". When not in use the bed converts to a desk and vice-versa.\n\n" +
                "Please note that some of the kitchens are not big enough for a dining table and chairs. The kitchens are fully equipped with cookers" +
                ", microwaves, toasters and kettles. Students need to bring their own towels, pots, pans" +
                " crockery, knives and forks.\n\n" +
                "The communal areas are cleaned Monday to Friday. To assist the cleaning staff you are asked to wash up after yourselves. " +
                "You are responsible for your own cleaning if you reside in a self-contained room.\n\n" +
                "All prices are wi-fi and bills inclusive.\n\n" +
                "" +
                "Mitre has a small car park accessible to all staff and students.";
            mitre.HouseImg = "https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/800%20Mitre%20front.jpg";
            await Navigation.PushAsync(new HouseInfoPage(mitre));
        }

        private async void paulleyHouse_Clicked(object sender, EventArgs e)
        {
            House paulley = new House();
            paulley.HouseName = "Paulley House";
            paulley.Address = "30 Hunter Street Buckingham MK18 1EG";
            paulley.HouseDescribe = "There are 42 single standard bedrooms. The top floor is reserved for females only." +
                "\n\nAll rooms have mini-cools, small vacuum cleaners and washbasins.\n\n" +
                "There are 2 showers and toilets per 7 students.\n\nThe kitchens are shared by 14 students. You will need to " +
                "bring your own kitchen items such as pots,pans, crockery, knives and forks.\n\n" +
                "The communal areas are cleaned from monday to friday.\n\n" +
                "Car parking is available at Verney Park.\n\n" +
                "These rooms have 4ft small double beds. Please bring your own suitable bedding.";
            paulley.HouseImg = "https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/IMG_0115.JPG";
            await Navigation.PushAsync(new HouseInfoPage(paulley));
            
        }

        
    }
}