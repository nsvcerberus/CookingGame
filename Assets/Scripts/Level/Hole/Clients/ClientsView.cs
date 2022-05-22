using UnityEngine;

namespace Cooking.Level.Hole.Clients
{
    public class ClientsView : View
    {
        [SerializeField] private ClientsSO clientsSO;

        public ClientView InstantiateRandomClient()
        {
            var randomIndex = Random.Range(0, clientsSO.Clients.Count);
            return Instantiate(clientsSO.Clients[randomIndex], transform);
        }
    }
}