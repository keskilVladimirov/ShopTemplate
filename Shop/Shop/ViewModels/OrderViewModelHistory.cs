using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    class OrderViewModelHistory : BindableObject
    {
        private ObservableCollection<Order> orders;
        public ObservableCollection<Order> Orders
        {
            get => orders;
            set
            {
                if (value == orders) return;
                orders = value;
                OnPropertyChanged();
            }
        }
        public OrderViewModelHistory()
        {
            Orders = new ObservableCollection<Order>()
            {
                new Order()
                {
                    Image = "Logo.png",
                    Name = "Имя заказа",
                    Price = "456",
                    Count = "1",
                    Adress = "Адрес",
                    DateTime = "Дата и время",
                },
                new Order()
                {
                    Image = "Logo.png",
                    Name = "Имя заказа",
                    Price = "456",
                    Count = "1",
                    Adress = "Адрес",
                    DateTime = "Дата и время",
                },
                new Order()
                {
                    Image = "Logo.png",
                    Name = "Имя заказа",
                    Price = "456",
                    Count = "1",
                    Adress = "Адрес",
                    DateTime = "Дата и время",
                },
            };
        }
    }
}
