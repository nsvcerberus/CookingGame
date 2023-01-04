using UnityEngine;
using System;

namespace Cooking.Level.Hole
{
    public class ClientsPresenter //: Presenter<Clients, ClientsModel>
    {
        public event Action ClientCreated;

        public event Func<Vector3> ReturnRandomEntryPosition;


        public ClientsPresenter(Clients view) //: base(view)
        {
            SetClientsPrefabs();
        }

        private void SetClientsPrefabs()
        {
            //var clientsPrefabs = view.ClientsSO.Clients;

            //if (clientsPrefabs.Count > 0)
            //{
            //    for (int i = 0; i < clientsPrefabs.Count; i++)
            //    {
            //        //model.AddClientPrefab(clientsPrefabs[i], i);
            //    }
            //}
        }


        public void CreateClient(ReceptionController orderPlace)
        {
            //var clientView = view.InstantiateClientPrefab(model.GetRandomeClientPrefab());
            //var client = new ClientPresenter(clientView, orderPlace, ReturnRandomEntryPosition.Invoke());
            ClientCreated?.Invoke();
        }
    }
}