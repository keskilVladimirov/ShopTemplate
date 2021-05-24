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
    public partial class EnterNumber : ContentPage
    {
        public EnterNumber()
        {
            InitializeComponent();
        }

        private void Confirm_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EnterSMS());
        }
    }
}