using Shop.ViewModels;
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
    public partial class UserData : ContentPage
    {
        public UserData()
        {
            InitializeComponent();
            WrapperStack.BindingContext = new UserDataViewModel().UserDatas.Last();
        }
    }
}