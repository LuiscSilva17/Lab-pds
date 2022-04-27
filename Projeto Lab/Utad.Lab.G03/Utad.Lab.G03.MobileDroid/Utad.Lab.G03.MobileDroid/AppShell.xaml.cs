using System;
using System.Collections.Generic;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Utad.Lab.G03.MobileDroid.Views;
using Xamarin.Forms;

namespace Utad.Lab.G03.MobileDroid
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
