using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Clients
{
    public class ClientsView : View
    {
        [SerializeField] private ClientsSO clientsSO;
        
        public ClientView InstantiateClientPrefab(ClientView prefab) => Instantiate(prefab, transform);

        public ClientsSO ClientsSO => clientsSO;
    }
}