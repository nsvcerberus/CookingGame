using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class ClientsPresenter : Presenter<ClientsView, ClientsModel>
    {
        public ClientsPresenter(ClientsView view) : base(view)
        {
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            model.Updated += () => view.SetText(model.WaitingClientsAmount, model.ClientsAmount);
        }

        public void SetClientsAmount(int value) => model.SetClientsAmount(value.ToString());
        public void SetWaitingClientsAmount(int value) => model.SetWaitingClientsAmount(value.ToString());
    }
}