using UnityEngine;
using Cooking.Level.Hole.Places;
using System;

namespace Cooking.Level.Hole.Clients
{
    public class ClientsPresenter : Presenter<ClientsView, ClientsModel>
    {
        public event Action ClientCreated;

        public event Func<Vector3> ReturnRandomEntryPosition;


        public ClientsPresenter(ClientsView view) : base(view)
        {
            SetClientsPrefabs();
        }

        private void SetClientsPrefabs()
        {
            var clientsPrefabs = view.ClientsSO.Clients;

            if (clientsPrefabs.Count > 0)
            {
                for (int i = 0; i < clientsPrefabs.Count; i++)
                {
                    model.AddClientPrefab(clientsPrefabs[i], i);
                }
            }
        }


        public void CreateClient(OrderPlacePresenter orderPlace)
        {
            var clientView = view.InstantiateClientPrefab(model.GetRandomeClientPrefab());
            var client = new ClientPresenter(clientView, orderPlace, ReturnRandomEntryPosition.Invoke());
            ClientCreated?.Invoke();
        }
    }
}