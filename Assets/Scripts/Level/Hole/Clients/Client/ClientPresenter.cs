using Cooking.Level.Hole.Places;
using UnityEngine;

namespace Cooking.Level.Hole.Clients
{
    public class ClientPresenter : Presenter<ClientView, ClientModel>
    {
        public OrderListPresenter OrderList { get; private set; }


        public ClientPresenter(ClientView view, OrderPlacePresenter orderPlace, Vector3 position) : base(view)
        {
            OrderList = new OrderListPresenter(view.OrderList);

            SubscribeToEvents();

            model.SetOrderPlace(orderPlace);
            
            view.SetAsFirstSibling();
            view.SetPosition(position);
            view.GoToOrderPlaceFromEntryPlace(model.OrderPlace.GetPosition());

            OrderList.Deactivate();
        }

        private void SubscribeToEvents()
        {
            view.ReturnSpeed += () => model.Speed;
            view.PlaceAnOrder += OrderList.Start;
        }
    }
}