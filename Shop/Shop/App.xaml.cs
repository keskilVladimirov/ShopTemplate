using Shop.Views.Registration;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop
{
    public partial class App : Application
    {
        public Style payment, paymentSelected;
        public bool subcategory = true, Sale= true;
        public App()
        {
            InitializeComponent();
            InitializationPublicStyles();
            MainPage = new StartPage();
        }
        void InitializationPublicStyles()
        {
            payment = Payment;
            paymentSelected = PaymentSelected;
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
