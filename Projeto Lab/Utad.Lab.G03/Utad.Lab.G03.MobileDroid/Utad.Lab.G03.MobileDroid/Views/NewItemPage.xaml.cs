using System;
using System.Collections.Generic;
using System.ComponentModel;
using Utad.Lab.G03.MobileDroid.Models;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}