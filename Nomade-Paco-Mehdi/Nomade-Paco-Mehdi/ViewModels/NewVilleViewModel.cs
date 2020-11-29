using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Nomade_Paco_Mehdi.Models;
using Xamarin.Forms;


namespace Nomade_Paco_Mehdi.ViewModels
{
    class NewVilleViewModel : BaseViewModel
{
        private string nom;
        private string description;
        private string codePostal;
        private string pays;

        public NewVilleViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }



        private bool ValidateSave(object arg)
        {
            return !String.IsNullOrWhiteSpace(Nom)
            && !String.IsNullOrWhiteSpace(Description)
            &&!String.IsNullOrWhiteSpace(CodePostal)
            && !String.IsNullOrWhiteSpace(Pays);
        }
        public string Nom
        {
            get => nom;
            set => SetProperty(ref nom, value);
        }
        public string CodePostal
        {
            get => codePostal;
            set => SetProperty(ref codePostal, value);
        }
        public string Pays
        {
            get => pays;
            set => SetProperty(ref pays, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }




        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave(object obj)
        {
            Ville newItem = new Ville()
            {
                VilleID = Guid.NewGuid().ToString(),
                Nom = Nom,
                Description = Description,
                CodePostal = CodePostal,
                Pays = Pays
            };

            await DataStoreVille.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    
}
}
