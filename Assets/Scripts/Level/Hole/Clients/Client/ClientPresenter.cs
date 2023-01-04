using UnityEngine;

namespace Cooking.Level.Hole
{
    public class ClientPresenter //: Presenter<Client, ClientModel>
    {
        //public OrderListPresenter OrderList { get; private set; }


        public ClientPresenter(Client view, ReceptionController orderPlace, Vector3 position) //: base(view)
        {
            //OrderList = new OrderListPresenter(view.OrderList);

            SubscribeToEvents();

            //model.SetOrderPlace(orderPlace);
            
            view.SetAsFirstSibling();
            view.SetPosition(position);
            //view.GoToOrderPlaceFromEntryPlace(model.OrderPlace.GetPosition());

            //OrderList.Deactivate();
        }

        private void SubscribeToEvents()
        {
            //view.ReturnSpeed += () => model.Speed;
            //view.PlaceAnOrder += OrderList.Start;
        }
    }
}