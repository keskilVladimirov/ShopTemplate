using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.Views.Registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            NewPage();
        }
        async void NewPage()
        {
            logo.Opacity = 0;
            await logo.FadeTo(1, 3000);
            App.Current.MainPage = new MainPage();
        }
    }
}