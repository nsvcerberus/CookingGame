using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class OrderPlacePresenter : Presenter<OrderPlaceView, OrderPlaceModel>
    {
        public event Action<OrderPlacePresenter> Free;
        public event Action Busy;

        public OrderPlacePresenter(OrderPlaceView view) : base(view) 
        {
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            model.FreeStateUpdated += CheckState;
        }


        public void Start()
        {
            OnFree();
        }


        private void CheckState()
        {
            if (model.FreeState)
                OnFree();
            else
                OnBusy();
        }

        private void OnFree() => Free?.Invoke(this);
        private void OnBusy() => Busy?.Invoke();

        public void SetFreeState() => model.SetFreeState(true);
        public void SetNonFreeState() => model.SetFreeState(false);

        public bool GetFreeState() => model.FreeState;
        public Vector3 GetPosition() => view.GetPosition();
    }
}