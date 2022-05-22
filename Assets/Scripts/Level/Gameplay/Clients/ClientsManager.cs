using System;

namespace Cooking.Level.Gameplay
{
    public class ClientsManager
    {
		public event Action<int> ClientsAmountUpdated;
		public event Action<int> WaitingClientsAmountUpdated;

		private int clientsAmount;
		private int waitingClientsAmount;


		public void Start()
		{
			OnClientsAmountUpdated(clientsAmount = 10);
			OnWaitingClientsAmountUpdated(waitingClientsAmount = 10);
		}

		private void OnClientsAmountUpdated(int value) => ClientsAmountUpdated?.Invoke(value);
		private void OnWaitingClientsAmountUpdated(int value) => WaitingClientsAmountUpdated?.Invoke(value);

		public void DecreaseWaitingClientsAmount() => OnWaitingClientsAmountUpdated(--waitingClientsAmount);
		public bool CheckIfCanCreateNewClient() => (waitingClientsAmount > 0) ? true : false;
	}
}