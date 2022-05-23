using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Clients
{
    public class OrderListPresenter : Presenter<OrderListView, Model>
    {
        public OrderListPresenter(OrderListView view) : base(view) { }

        public void Start()
        {
            Activate();
        }
    }
}