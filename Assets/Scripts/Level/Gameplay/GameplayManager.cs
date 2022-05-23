using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Gameplay
{
    public class GameplayManager
    {
        public event Action Started;

        public ClientsManager Clients { get; private set; }
        public TimerManager Timer { get; private set; }


        public GameplayManager()
        {
            Clients = new ClientsManager();
            Timer = new TimerManager();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            Timer.Ended += Stop;
        }


        public void Start()
        {
            Clients.Start();
            Timer.Start();

            Started?.Invoke();
        }

        private void Stop()
        {
            Debug.Log("GAME OVER");
        }
    }
}