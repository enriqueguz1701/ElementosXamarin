using ElementosBasicos.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElementosBasicos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Tarjeta());
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
