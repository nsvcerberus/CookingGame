using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Cooking.Level
{
    public class OrdersManager : Singleton<OrdersManager>
    {
		public event Action<int, int> ClientsDataUpdated;

		private int clientsAmount;
		private int clientsServedAmount;

		public void Start()
		{
			GameplayManager.instance.GameplayStarted += ResetData;
		}

        private void ResetData()
        {
			clientsAmount = 10;
			clientsServedAmount = 0;
			OnDataUpdated();
		}

		async public void InviteClient(Vector3 receptionPosition)
        {
			await Task.Run(() => {
				/*
				if (waitingClientsAmount > 0)
                {
					waitingClientsAmount--;
					OnDataUpdated();
				}
				*/
			});
		}

		public bool CheckIfCanCreateNewClient() => (clientsServedAmount > 0) ? true : false;

		private void OnDataUpdated() => ClientsDataUpdated?.Invoke(clientsServedAmount, clientsAmount);
	}
}