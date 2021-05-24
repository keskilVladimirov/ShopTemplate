using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.Views.UserPages.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsList : ContentPage
    {
        public ProductsList(Category category)
        {
            InitializeComponent();
            HeaderLabel.Text = category.Name;
            ItemsCollection.BindingContext = new ItemViewModel();
            FilterPicker.BindingContext = new FilterViewModel();
            FilterPicker.SetBinding(Picker.ItemsSourceProperty, "Filters");
            FilterPicker.ItemDisplayBinding = new Binding("Name");
            Sorting.Items.Add("По возрастанию цены");
            Sorting.Items.Add("По убыванию цены");
            App app = new App();
            if (app.Sale)
            {
                Sorting.Items.Add("Скидка");
            }
        }

        private void ItemsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                ItemsCollection.SelectedItem = null;
                Navigation.PushAsync(new ProductInfo(e.CurrentSelection.LastOrDefault() as Item));
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bonus());
        }
    }
}