using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    using System.ComponentModel;
    public class Room : INotifyPropertyChanged
    {
        private string houseName;
        private string rmName;
        private string rmSize;
        private string rmKitchen;
        private string rmBath;        
        private string rmPrice;
        private List<string> rmImages = new List<string>();
        private string rmImage;
        public int i = 0;
        private int count;       

        public string RmName { get => rmName; set => rmName = value; }
        public string RmSize { get => rmSize; set => rmSize = value; }
        public string RmKitchen { get => rmKitchen; set => rmKitchen = value; }
        public string RmBath { get => rmBath; set => rmBath = value; }        
        public string HouseName { get => houseName; set => houseName = value; }
        public string RmPrice { get => rmPrice; set => rmPrice = value; }
        public List<string> RmImages { get => rmImages; set => rmImages = value; }
        public string RmImage { get => rmImage;  
            set
            {
                if (rmImage != value)
                {
                    rmImage = value;
                    OnChangedProperty("RmImage"); 
                };
            }
        }

        public int Count { get => count; set 
            {
                if (count != value)
                {
                    count = value;
                    OnChangedProperty("Count");
                };
            } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnChangedProperty(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
