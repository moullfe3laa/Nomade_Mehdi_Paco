using System.ComponentModel;
using Xamarin.Forms;
using Nomade_Paco_Mehdi.ViewModels;

namespace Nomade_Paco_Mehdi.Views
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