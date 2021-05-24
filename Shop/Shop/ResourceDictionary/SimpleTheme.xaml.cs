using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("NeoSansPro-Regular.ttf", Alias = "NeoSansPro")]
[assembly: ExportFont("NeoSansPro-Medium.ttf", Alias = "NeoSansProBold")]

namespace Shop.ResourceDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleTheme
    {
        public SimpleTheme()
        {
            InitializeComponent();
        }
    }
}