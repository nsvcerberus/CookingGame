using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class ClientsModel : Model
    {
        public event Action Updated;

		public string ClientsAmount { get; private set; }
        public string WaitingClientsAmount { get; private set; }


        public void SetClientsAmount(string value)
        {
            ClientsAmount = value;
            OnUpdated();
        }

        public void SetWaitingClientsAmount(string value)
        {
            WaitingClientsAmount = value;
            OnUpdated();
        }

        private void OnUpdated() => Updated?.Invoke();
    }
}