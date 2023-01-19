using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;

namespace Cooking.Editor.LevelsData
{ 
    [Serializable]
    public class LevelData
    {
        public int number;
        [ListDrawerSettings(CustomAddFunction = "AddNewClient")] public List<ClientData> clients;

        private ClientData AddNewClient()
        {
            var client = new ClientData();
            client.name = client.GetClientsNames().First();
            client.sweets = new List<Sweetness>();
            return client;
        }
    }
}