using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cooking.Level.UserInterface
{
    public class ClientsView : View
    {
        [SerializeField] private Text text;

        public void SetText(string waitingClientsAmount, string clientsAmount)
        {
            text.text = waitingClientsAmount + " / " + clientsAmount;
        }
    }
}