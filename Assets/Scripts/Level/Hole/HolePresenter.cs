using System;
using Cooking.Level.Hole.Places;
using Cooking.Level.Hole.Clients;

namespace Cooking.Level.Hole
{
    public class HolePresenter : Presenter<HoleView, Model>
    {
        public event Func<bool> CheckIfCanCreateNewClient;

        public PlacesPresenter Places { get; private set; }
        public ClientsPresenter Clients { get; private set; }


        public HolePresenter(HoleView view) : base(view)
        {
            Places = new PlacesPresenter(view.Places);
            Clients = new ClientsPresenter(view.Clients);

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            Places.OrderPlaces.FreedOrderPlace += CreateNewClient;
            Clients.ReturnRandomEntryPosition += Places.EntryAndExitPlaces.GetRandomPosition;
        }


        public void Start()
        {
            Places.OrderPlaces.Start();
        }

        private void CreateNewClient(OrderPlacePresenter orderPlace)
        {
            if (CheckIfCanCreateNewClient.Invoke())
                Clients.CreateClient(orderPlace);
        }
    }
}