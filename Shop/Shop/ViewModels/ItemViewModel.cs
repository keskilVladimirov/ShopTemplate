using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    class ItemViewModel : BindableObject
    {
        private ObservableCollection<Item> items;
        public ObservableCollection<Item> Items
        {
            get => items;
            set
            {
                if (value == items) return;
                items = value;
                OnPropertyChanged();
            }
        }
        public ItemViewModel()
        {
            Items = new ObservableCollection<Item>()
            {
                new Item()
                {
                    Image = "Logo.png",
                    Name = "Имя товара",
                    Price = "456",
                    OldPrice = "567",
                    Description = "Описание товара",
                    Discount = true,
                    Count = "1",
                },
                new Item()
                {
                    Image = "Logo.png",
                    Name = "Имя товара",
                    Price = "456",
                    Description = "Описание товара",
                    Discount = false,
                    Count = "1",
                },
                new Item()
                {
                    Image = "Logo.png",
                    Name = "Имя товара",
                    Price = "456",
                    Description = "Описание товара",
                    Discount = false,
                    Count = "1",
                },
            };
        }
    }
}