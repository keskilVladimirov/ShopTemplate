using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.Views.UserPages.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersDetail : ContentPage
    {
        public OrdersDetail(Order order)
        {
            InitializeComponent();
            ItemsCollection.BindingContext = new ItemViewModel();
            SpanSum.Text = order.Price;
        }

    }
}