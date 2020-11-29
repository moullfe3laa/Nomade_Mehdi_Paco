using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Nomade_Paco_Mehdi.Models;
using Nomade_Paco_Mehdi.Views;
using Nomade_Paco_Mehdi.ViewModels;

namespace Nomade_Paco_Mehdi.Views
{
    public partial class VillesPage : ContentPage
    {
        VillesViewModel _viewModel;


        public VillesPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new VillesViewModel();
        }

    

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}