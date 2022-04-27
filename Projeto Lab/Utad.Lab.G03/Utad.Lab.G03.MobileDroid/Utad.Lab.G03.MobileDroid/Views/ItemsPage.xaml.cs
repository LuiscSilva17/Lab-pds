using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utad.Lab.G03.MobileDroid.Models;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Utad.Lab.G03.MobileDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}