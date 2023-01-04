using TMPro;
using UnityEngine;

namespace Cooking.Level.UI.Statistics
{
    public class Clients : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;

        private void Start()
        {
            
        }

        public void SetText(string waitingClientsAmount, string clientsAmount)
        {
            text.text = waitingClientsAmount + " / " + clientsAmount;
        }
    }
}