using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole
{
    public class ClientsModel : Model
    {
        public Dictionary<int, Client> ClientsPrefabs { get; private set; }
        public List<int> ClientsIdOnScene { get; private set; }


        public ClientsModel()
        {
            ClientsPrefabs = new Dictionary<int, Client>();
            ClientsIdOnScene = new List<int>();
        }

        public void AddClientPrefab(Client prefab, int id) => ClientsPrefabs.Add(id, prefab);
        public void AddClientIdOnScene(int id) => ClientsIdOnScene.Add(id);


        public Client GetRandomeClientPrefab()
        {
            var keys = new List<int>(ClientsPrefabs.Keys);
            var keysForRandom = new List<int>();

            for (int i = 0; i < keys.Count; i++)
            {
                if (!ClientsIdOnScene.Contains(keys[i]))
                    keysForRandom.Add(keys[i]);
            }

            var randomIndex = Random.Range(0, keysForRandom.Count);
            var randomKey = keysForRandom[randomIndex];

            ClientsIdOnScene.Add(randomKey);
            return ClientsPrefabs[randomKey];
        }
    }
}