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
    public partial class Buy : ContentPage
    {
        public Buy()
        {
            InitializeComponent();
        }
        private void CardOnline_Clicked(object sender, EventArgs e)
        {
            App app = new App();
            ClearMethodPayment();
            CardOnline.Style = app.paymentSelected;
        }

        private void Card_Clicked(object sender, EventArgs e)
        {
            App app = new App();
            ClearMethodPayment();
            Card.Style = app.paymentSelected;
        }

        private void Cash_Clicked(object sender, EventArgs e)
        {
            App app = new App();
            ClearMethodPayment();
            DeliveryOfMoney.IsVisible = true;
            Cash.Style = app.paymentSelected;
        }
        void ClearMethodPayment()
        {
            App app = new App();
            Cash.Style = app.payment;
            CardOnline.Style = app.payment;
            Card.Style = app.payment;
            DeliveryOfMoney.IsVisible = false;
        }

        private async void Confirm_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Внимание", "Вы действительно хотите осуществить заказ?", "Да", "Нет");
            if (result)
            {
                await DisplayAlert("Внимание", "Заказ осуществлен, ожидайте", "Понятно");
                await Navigation.PopToRootAsync();
            }
        }
    }
}