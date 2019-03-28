using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Symfony
{
    class ServicesWeb
    {
        private HttpClient Client;
        public string ligne;

        public ServicesWeb()
        {
            Client = new HttpClient();
            Client.MaxResponseContentBufferSize = 2000000000000000000;

        }

        // async on lance un nouveau thread 
        public async Task<List<RecupListeUser>> GetInfosAsync()
        {
            Uri uri = new Uri("https://kroko.ovh/~soares/TestSymfony/public/index.php/listeUserMobile");

            var ReponseServeur = await Client.GetAsync(uri);

            if (ReponseServeur.IsSuccessStatusCode)
            {
                var Donnees = await ReponseServeur.Content.ReadAsStringAsync();
                //Debug.WriteLine(Donnees); affiche le retour du Json 
                //return Donnees;
                List<RecupListeUser> listeUnites = JsonConvert.DeserializeObject<List<RecupListeUser>>(Donnees);
                return listeUnites;


            }
            else
            {
                Debug.WriteLine("ça marche app");
            }
            return null;
        }

    }
}
