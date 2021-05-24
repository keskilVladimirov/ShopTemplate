using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.Views.UserPages.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void UserData_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserData());
        }

        private void OrganisationData_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrganisationData());
        }
    }
}