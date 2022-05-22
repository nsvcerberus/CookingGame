using UnityEngine;
using Cooking.Level.Hole.Places;
using System;

namespace Cooking.Level.Hole.Clients
{
    public class ClientsPresenter : Presenter<ClientsView, Model>
    {
        public event Action ClientCreated;

        public event Func<Vector3> ReturnRandomEntryPosition;

        public ClientsPresenter(ClientsView view) : base(view) { }

        
        public void CreateClient(OrderPlacePresenter orderPlace)
        {
            new ClientPresenter(view.InstantiateRandomClient(), orderPlace, ReturnRandomEntryPosition.Invoke());
            ClientCreated?.Invoke();
        }
    }
}