using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Nomade_Paco_Mehdi.Models;
using Nomade_Paco_Mehdi.Views;

namespace Nomade_Paco_Mehdi.ViewModels
{
    [QueryProperty(nameof(VilleId), nameof(VilleId))]
    class VilleDetailViewModel:BaseViewModel
{
        private string nom;
        private string description;
        private string codePostal;
        private string pays;
        private string villeId;
        public string Nom
        {
            get => nom;
            set => SetProperty(ref nom, value);
        }
        public string Pays
        {
            get => pays;
            set => SetProperty(ref pays, value);
        }
        
        public string CodePostal
        {
            get => codePostal;
            set => SetProperty(ref codePostal, value);
        }
        public string VilleId
        {
            get
            {
                return villeId;
            }
            set
            {
                villeId = value;
                LoadItemId(value);
            }
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
    

        public async Task LoadItemId(string VilleID)
        {
            try
            {
                var ville = await DataStoreVille.GetItemAsync(VilleID);
                Nom = ville.Nom;
                Description = ville.Description;
                CodePostal = ville.CodePostal;
                Pays = ville.Pays;
                VilleId = ville.VilleID;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
