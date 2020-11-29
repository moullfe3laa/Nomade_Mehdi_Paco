using Nomade_Paco_Mehdi.Models;
using Nomade_Paco_Mehdi.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nomade_Paco_Mehdi.ViewModels
{
    class VillesViewModel : BaseViewModel
{
    private Ville _selectedItem;

    public ObservableCollection<Ville> Items { get; }
    public Command LoadItemsCommand { get; }
    public Command AddItemCommand { get; }
    public Command<Ville> ItemTapped { get; }

    public VillesViewModel()
    {
        Title = "Browse";
        Items = new ObservableCollection<Ville>();
        LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        ItemTapped = new Command<Ville>(OnItemSelected);

        AddItemCommand = new Command(OnAddItem);
    }

    async Task ExecuteLoadItemsCommand()
    {
        IsBusy = true;

        try
        {
            Items.Clear();
            var villes = await DataStoreVille.GetItemsAsync(true);
            foreach (var ville in villes)
            {
                Items.Add(ville);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
        finally
        {
            IsBusy = false;
        }
    }

    public void OnAppearing()
    {
        IsBusy = true;
        SelectedItem = null;
    }

    public Ville SelectedItem
    {
        get => _selectedItem;
        set
        {
            SetProperty(ref _selectedItem, value);
            OnItemSelected(value);
        }
    }

    private async void OnAddItem(object obj)
    {
        await Shell.Current.GoToAsync(nameof(NewVilleViewModel));
    }

    async void OnItemSelected(Ville item)
    {
        if (item == null)
            return;

        // This will push the ItemDetailPage onto the navigation stack
        await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(VilleDetailViewModel.VilleId)}={item.VilleID}");
    }
}
}
