using System;
using System.Collections.Generic;
using Nomade_Paco_Mehdi.ViewModels;
using Nomade_Paco_Mehdi.Views;
using Xamarin.Forms;

namespace Nomade_Paco_Mehdi
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            Routing.RegisterRoute(nameof(VilleDetailPage), typeof(VilleDetailPage));
            Routing.RegisterRoute(nameof(NewVillePage), typeof(NewVillePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
