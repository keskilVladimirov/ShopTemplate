using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    class UserDataViewModel: BindableObject
    {
        private ObservableCollection<UserData> userDatas;
        public ObservableCollection<UserData> UserDatas
        {
            get => userDatas;
            set
            {
                if (value == userDatas) return;
                userDatas = value;
                OnPropertyChanged();
            }
        }
        public UserDataViewModel()
        {
            UserDatas = new ObservableCollection<UserData>()
            {
                new UserData()
                {
                    Phone = "Номер",
                    Name = "Имя",
                    StreetName = "Название улицы",
                    HouseNumber = "Номер дома",
                    FrontDoorNumber = "Номер подъезда",
                    FloorNumber = "Номер этажа",
                    ApartmentNumber = "Номер квартиры",
                },
            };
        }
    }
}
