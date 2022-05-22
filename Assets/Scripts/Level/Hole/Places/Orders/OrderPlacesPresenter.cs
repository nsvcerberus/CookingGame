using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class OrderPlacesPresenter : Presenter<OrderPlacesView, Model>
    {
        public event Action<OrderPlacePresenter> FreedOrderPlace;

        public List<OrderPlacePresenter> Objects { get; private set; }

        public OrderPlacesPresenter(OrderPlacesView view) : base(view)
        {
            Objects = new List<OrderPlacePresenter>();

            CreateOrders();
            SubscribeToEvents();
        }

        private void CreateOrders()
        {
            for (int i = 0; i < view.Objects.Count; i++)
            {
                Objects.Add(new OrderPlacePresenter(view.Objects[i]));
            }
        }
        private void SubscribeToEvents()
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                var obj = Objects[i];
                Objects[i].Free += (OrderPlacePresenter obj) => FreedOrderPlace?.Invoke(obj);
            }
        }


        public void Start()
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                Objects[i].Start();
            }
        }


        private void CheckObjectState(bool value)
        {
            if (value)
                CreateClient();
            else
                StartOrder();
        }

        private void CreateClient() { }
        private void StartOrder() { }
    }
}