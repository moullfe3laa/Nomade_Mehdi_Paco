using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Nomade_Paco_Mehdi.Models;
using Nomade_Paco_Mehdi.ViewModels;

namespace Nomade_Paco_Mehdi.Views
{
    public partial class NewVillePage : ContentPage
    {
        public Ville Item { get; set; }

        public NewVillePage()
        {
            InitializeComponent();
            BindingContext = new NewVilleViewModel();
        }

        
    }
}