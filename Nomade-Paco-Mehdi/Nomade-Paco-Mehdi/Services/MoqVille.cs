using Nomade_Paco_Mehdi.Models;
using Nomade_Paco_Mehdi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomade_Paco_Mehdi.Services
{
  public  class MoqVille : IDataStore<Ville>
    {
        readonly List<Ville> villes;

        public MoqVille()
        {
            villes = new List<Ville>()
            {
                new Ville { VilleID="1",  Nom = "Grenoble", Description="Ville Sympa" ,CodePostal = "38000",Pays = "France" },
                new Ville { VilleID="2",  Nom = "Paris", Description="Capitale" ,CodePostal = "XXXXXX",Pays = "France"  },
                new Ville { VilleID="3",  Nom = "Marseille",Description="La plage" ,CodePostal = "WWWWWWW",Pays = "France"  },
            };
        }
        public async Task<bool> AddItemAsync(Ville item)
        {
            villes.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = villes.Where((Ville arg) => arg.VilleID == id).FirstOrDefault();
            villes.Remove(oldItem);
            return await Task.FromResult(true);
        }

        public async Task<Ville> GetItemAsync(string id)
        {
            return await Task.FromResult(villes.FirstOrDefault(s => s.VilleID == id));
        }

        public async Task<IEnumerable<Ville>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(villes);
        }

        public async Task<bool> UpdateItemAsync(Ville item)
        {
            var oldItem = villes.Where((Ville arg) => arg.VilleID == item.VilleID).FirstOrDefault();
            villes.Remove(oldItem);
            villes.Add(item);
            return await Task.FromResult(true);
        }
    }

}
