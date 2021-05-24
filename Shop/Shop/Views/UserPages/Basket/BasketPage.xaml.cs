using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.Views.UserPages.Basket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPage : ContentPage
    {
        public BasketPage()
        {
            InitializeComponent();
            OrderCollection.BindingContext = new ItemViewModel();
        }

        private void Basket_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Buy());
        }
    }
}