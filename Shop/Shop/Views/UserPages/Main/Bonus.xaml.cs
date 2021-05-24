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
    public partial class Bonus : ContentPage
    {
        public Bonus()
        {
            InitializeComponent();
            BonusCollection.BindingContext = new BonusViewModel();
        }
    }
}