using System;
using Newtonsoft.Json;

namespace Symfony
{

    public class RecupListeUser
    {
        [JsonProperty(PropertyName = "ID")]
        public int id;

        [JsonProperty(PropertyName = "Categorie")]
        public String categorie;

        [JsonProperty(PropertyName = "Marque")]
        public String marque;

        [JsonProperty(PropertyName = "Description")]
        public String description;

        [JsonProperty(PropertyName = "Etat")]
        public String etat;
    }
}

