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
    public partial class CategoryPages : ContentPage
    {
        public CategoryPages()
        {
            InitializeComponent();
            CategoriesCollection.BindingContext = new CategoryViewModel();
        }

        private void CategoriesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App app = new App();
            if (e.CurrentSelection.Any())
            {
                CategoriesCollection.SelectedItem = null;
                if (app.subcategory)
                {
                    Navigation.PushAsync(new SubCategory(e.CurrentSelection.LastOrDefault() as Category));
                }
                else
                {
                    Navigation.PushAsync(new ProductsList(e.CurrentSelection.LastOrDefault() as Category));
                }
            }
        }

        private void Find_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Find());
        }
    }
}