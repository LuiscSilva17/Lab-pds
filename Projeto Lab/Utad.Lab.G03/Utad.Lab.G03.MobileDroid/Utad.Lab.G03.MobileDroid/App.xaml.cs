using System;
using Utad.Lab.G03.MobileDroid.Services;
using Utad.Lab.G03.MobileDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
