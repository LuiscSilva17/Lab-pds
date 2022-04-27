using System.ComponentModel;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Xamarin.Forms;

namespace Utad.Lab.G03.MobileDroid.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}