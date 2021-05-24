using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    class CategoryViewModel : BindableObject
    {
        private ObservableCollection<Category> categories;
        public ObservableCollection<Category> Categories
        {
            get => categories;
            set
            {
                if (value == categories) return;
                categories = value;
                OnPropertyChanged();
            }
        }
        public CategoryViewModel()
        {
            Categories = new ObservableCollection<Category>()
            {
                new Category()
                {
                    Name = "Имя категории",
                    Image = "Logo.png",
                },
                new Category()
                {
                    Name = "Имя категории",
                    Image = "Logo.png",
                },
                new Category()
                {
                    Name = "Имя категории",
                    Image = "Logo.png",
                },
            };
        }
    }
}
