using Shop.Models;
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
    public partial class ProductInfo : ContentPage
    {
        Item _item;
        public ProductInfo(Item item)
        {
            InitializeComponent();
            HeaderLabel.Text = item.Name;
            MainStack.BindingContext = item;
            _item = item;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bonus());
        }

        private async void AddBasket_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Внимание", "Вы действительно хотите добавить товар в корзину?", "Да", "Нет");
            if (result)
            {
                await DisplayAlert("Внимание", "Товар добавлен в корзину", "Понятно");
            }
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Count.Text);
            if(count != 1)
            {
                count -= 1;
                Count.Text = count.ToString();
                Price.Text = (Convert.ToInt32(_item.Price) * count).ToString();
            }
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Count.Text);
            count += 1;
            Count.Text = count.ToString();
            Price.Text = (Convert.ToInt32(_item.Price) * count).ToString();
        }
    }
}