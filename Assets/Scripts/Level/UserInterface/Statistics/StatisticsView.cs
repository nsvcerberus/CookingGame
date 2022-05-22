using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class StatisticsView : View
    {
        [SerializeField] private ClientsView clients;
        [SerializeField] private TimerView timer;

        public ClientsView Clients => clients;
        public TimerView Timer => timer;
    }
}