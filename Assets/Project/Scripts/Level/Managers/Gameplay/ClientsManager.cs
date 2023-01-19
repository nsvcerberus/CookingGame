using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Cooking.Level
{
    public class ClientsManager : Singleton<ClientsManager>
    {
		public event Action<int, int> ClientsDataUpdated;
		public event Action<Vector3> CreateClient;

		private int clientsAmount;
		private int clientsServedAmount;
		private int clientsInLineAmount;

		public void Start()
		{
			GameplayManager.instance.GameplayStarted += ResetData;
		}

        private void ResetData()
        {
			clientsAmount = 10;
			clientsServedAmount = 0;
			clientsInLineAmount = clientsAmount;
			OnDataUpdated();
		}

		public void InviteClient(Vector3 receptionPosition)
		{
			CreateClient?.Invoke(receptionPosition);
			clientsInLineAmount--;
			/*
			Task.Run(() => {
				if (waitingClientsAmount > 0)
				{
					waitingClientsAmount--;
					OnDataUpdated();
				}
			});
			*/
		}

		public bool CheckIfCanCreateNewClient() => (clientsServedAmount > 0) ? true : false;

		private void OnDataUpdated() => ClientsDataUpdated?.Invoke(clientsServedAmount, clientsAmount);
	}
}