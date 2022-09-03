using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    public class House
    {
        private string houseName;
        private string address;
        private string houseDescribe;
        private string houseImg;
        
        

        public string HouseName { get => houseName; set => houseName = value; }
        public string Address { get => address; set => address = value; }
        public string HouseDescribe { get => houseDescribe; set => houseDescribe = value; }
        public string HouseImg { get => houseImg; set => houseImg = value; }
    }
}
