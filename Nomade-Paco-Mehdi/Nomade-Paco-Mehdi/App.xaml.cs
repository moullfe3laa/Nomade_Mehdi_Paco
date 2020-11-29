using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Nomade_Paco_Mehdi.Services;
using Nomade_Paco_Mehdi.Views;

namespace Nomade_Paco_Mehdi
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MoqVille>();
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
