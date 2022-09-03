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
    public partial class HouseInfoPage : ContentPage
    {
        House houseCopy = new House();
        public HouseInfoPage(House houseObject)
        {
            InitializeComponent();
            houseCopy = houseObject;
            HouseNameLbl.Text = houseCopy.HouseName;
            HouseDescriptionLbl.Text = houseCopy.HouseDescribe;
            HouseAddressLbl.Text = houseCopy.Address;
            HouseInfoImg.Source = houseCopy.HouseImg;
        }

        

        
        private void ViewRoomButton_Clicked(object sender, EventArgs e)
        {
            if (HouseNameLbl.Text == "Caine House") //Creates objects based on each House. 
                                                    //When each view button is clicked it creates Room objects and initializes them
            {
                Room caineStandard = new Room();
                caineStandard.RmName = "Standard";
                caineStandard.HouseName = "Caine House";
                caineStandard.RmSize = "75.35";
                caineStandard.RmBath = "Shared";
                caineStandard.RmKitchen = "Shared";
                caineStandard.RmPrice = "6005.29";
                caineStandard.Count = 27;
                caineStandard.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Cai%20bedroom2.JPG");
                caineStandard.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Verney%20kitchen1.JPG");

                Room caineSelfCon = new Room();
                caineSelfCon.RmName = "En-Suite";
                caineSelfCon.HouseName = "Caine House";
                caineSelfCon.RmSize = "155.35";
                caineSelfCon.RmBath = "En-Suite";
                caineSelfCon.RmKitchen = "Open plan";
                caineSelfCon.RmPrice = "10781.14";
                caineSelfCon.Count = 4;
                caineSelfCon.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Nor%20living%20room3.JPG");
                caineSelfCon.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Nor%20kitchen.JPG");
                caineSelfCon.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Nor%20bedroom.JPG");

                List<Room> caineRooms = new List<Room>(); //creates a list for type Room
                caineRooms.Add(caineSelfCon);
                caineRooms.Add(caineStandard); //passes all the created and initialized Room objects into the list

                Navigation.PushAsync(new roomsPage(caineRooms)); //The roomsPage is pushed on top of the stack with the list of Rooms as parameter
            }

            else if (HouseNameLbl.Text == "Beloff House")
            {
                Room beloffRoom = new Room();
                beloffRoom.RmName = "Beloff Standard";
                beloffRoom.HouseName = "Beloff House";
                beloffRoom.RmSize = "90.05";
                beloffRoom.RmBath = "Shared";
                beloffRoom.RmKitchen = "Shared";
                beloffRoom.RmPrice = "8085.86";
                beloffRoom.Count = 30;
                beloffRoom.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Bel%20shower%20room.jpg");
                beloffRoom.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Bel%20kitchen.jpg");

                Room beloffRoomDisabled = new Room();
                beloffRoomDisabled.RmName = "Beloff Standard";
                beloffRoomDisabled.HouseName = "Beloff House";
                beloffRoomDisabled.RmSize = "90.05";
                beloffRoomDisabled.RmBath = "Shared";
                beloffRoomDisabled.RmKitchen = "Shared";
                beloffRoomDisabled.RmPrice = "8085.86";
                beloffRoomDisabled.Count = 12;
                beloffRoomDisabled.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Bel%20bedroom3.jpg");
                beloffRoomDisabled.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Bel%20shower%20room.jpg");
                beloffRoomDisabled.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Bel%20mini%20kitchen.jpg");

                List<Room> beloffRooms = new List<Room>();
                beloffRooms.Add(beloffRoomDisabled);
                beloffRooms.Add(beloffRoom);                

                Navigation.PushAsync(new roomsPage(beloffRooms));
            }

            else if (HouseNameLbl.Text == "Mitre House")
            {
                Room selfContainedSmall = new Room();
                selfContainedSmall.RmName = "Self contained (small)";
                selfContainedSmall.HouseName = "Mitre House";
                selfContainedSmall.RmSize = "200.00";
                selfContainedSmall.RmBath = "En-Suite";
                selfContainedSmall.RmKitchen = "Open plan";
                selfContainedSmall.RmPrice = "7660.29";
                selfContainedSmall.Count = 20;
                selfContainedSmall.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/800%20large%20room2.jpg");
                selfContainedSmall.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/MM%20kitchen.JPG");
                

                Room selfContainedLarge = new Room();
                selfContainedLarge.RmName = "Self contained (Large)";
                selfContainedLarge.HouseName = "Mitre House";
                selfContainedLarge.RmSize = "100.20";
                selfContainedLarge.RmBath = "En-Suite";
                selfContainedLarge.RmKitchen = "Private";
                selfContainedLarge.RmPrice = "11064.86";
                selfContainedLarge.Count = 10;
                selfContainedLarge.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Har%20bedroom2.JPG");
                selfContainedLarge.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Lon%20kitchen.JPG");

                Room mitreStandard = new Room();
                mitreStandard.RmName = "Standard";
                mitreStandard.HouseName = "Mitre House";
                mitreStandard.RmSize = "90.20";
                mitreStandard.RmBath = "Shared";
                mitreStandard.RmKitchen = "Shared";
                mitreStandard.RmPrice = "7660.29";
                mitreStandard.Count = 30;
                mitreStandard.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/800%20large%20room3.jpg");
                mitreStandard.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/800%20kitchen.jpg");

                List<Room> mitreRooms = new List<Room>();
                mitreRooms.Add(mitreStandard);
                mitreRooms.Add(selfContainedLarge);
                mitreRooms.Add(selfContainedSmall);

                Navigation.PushAsync(new roomsPage(mitreRooms));
            }

            else if (HouseNameLbl.Text == "Paulley House")
            {
                Room paulleyRoom = new Room();
                paulleyRoom.RmName = "Paulley Standard";
                paulleyRoom.HouseName = "Beloff House";
                paulleyRoom.RmSize = "102.10";
                paulleyRoom.RmBath = "Shared";
                paulleyRoom.RmKitchen = "Shared";
                paulleyRoom.RmPrice = "6430.86";
                paulleyRoom.Count = 42;
                paulleyRoom.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Pau%20bedroom1.JPG");
                paulleyRoom.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Pau%20bedroom2.JPG");
                paulleyRoom.RmImages.Add("https://rooms.buckingham.ac.uk/Buckingham_Portal/Media/Area/Verney%20kitchen1.JPG");

                List<Room> paulleyRooms = new List<Room>();
                paulleyRooms.Add(paulleyRoom);

                Navigation.PushAsync(new roomsPage(paulleyRooms));
            }

            else return;
        }
        
    }
}