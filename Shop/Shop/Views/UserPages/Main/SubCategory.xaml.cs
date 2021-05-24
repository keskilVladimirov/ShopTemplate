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
    public partial class SubCategory : ContentPage
    {
        public SubCategory(Category category)
        {
            InitializeComponent();
            CategoriesCollection.BindingContext = new CategoryViewModel();
            HeaderLabel.Text = category.Name;
        }

        private void CategoriesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                CategoriesCollection.SelectedItem = null;
                Navigation.PushAsync(new ProductsList(e.CurrentSelection.LastOrDefault() as Category));
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bonus());
        }
    }
}