using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    class FilterViewModel : BindableObject
    {
        private ObservableCollection<Filter> filters;
        public ObservableCollection<Filter> Filters
        {
            get => filters;
            set
            {
                if (value == filters) return;
                filters = value;
                OnPropertyChanged();
            }
        }
        public FilterViewModel()
        {
            Filters = new ObservableCollection<Filter>()
            {
                new Filter()
                {
                    Name = "Все",
                },
                new Filter()
                {
                    Name = "Название фильтра",
                },
                new Filter()
                {
                    Name = "Название фильтра",
                },
                new Filter()
                {
                    Name = "Название фильтра",
                },
            };
        }
    }
}
