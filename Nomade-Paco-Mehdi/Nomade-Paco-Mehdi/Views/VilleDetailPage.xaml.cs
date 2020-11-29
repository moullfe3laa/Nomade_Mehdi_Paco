using System.ComponentModel;
using Xamarin.Forms;
using Nomade_Paco_Mehdi.ViewModels;
using System;

namespace Nomade_Paco_Mehdi.Views
{
    public partial class VilleDetailPage : ContentPage
    {
        public VilleDetailPage()
        {
            InitializeComponent();
            BindingContext = new VilleDetailViewModel();
        }

   
    }
}