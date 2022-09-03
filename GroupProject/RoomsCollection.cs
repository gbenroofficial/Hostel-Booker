using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GroupProject
{
    public class RoomsCollection:INotifyPropertyChanged
    {
        private ObservableCollection<Room> roomList;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Room> RoomList { get => roomList; set 
            {
                roomList = value;
                OnPropertyChanged("RoomList");
            } }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public RoomsCollection()
        {
            roomList = new ObservableCollection<Room>();

        }
    }
}
