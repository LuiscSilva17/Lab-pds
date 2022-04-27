using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}