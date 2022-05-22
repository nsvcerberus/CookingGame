using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class StatisticsPresenter : Presenter<StatisticsView, Model>
    {
        public ClientsPresenter Clients { get; private set; }
        public TimerPresenter Timer { get; private set; }

        public StatisticsPresenter(StatisticsView view) : base(view)
        {
            Clients = new ClientsPresenter(view.Clients);
            Timer = new TimerPresenter(view.Timer);
        }
    }
}