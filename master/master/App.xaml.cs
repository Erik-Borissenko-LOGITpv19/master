using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace master
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new masterdetailpage1();
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
