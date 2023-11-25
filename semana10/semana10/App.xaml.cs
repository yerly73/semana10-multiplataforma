using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using semana10.Views;
namespace semana10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Operaciones();
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
