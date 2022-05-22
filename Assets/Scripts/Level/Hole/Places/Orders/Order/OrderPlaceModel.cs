using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class OrderPlaceModel : Model
    {
        public event Action FreeStateUpdated;

        #region FreeState
        private bool freeState;
        public bool FreeState
        {
            get { return freeState; }
            private set 
            { 
                freeState = value;
                FreeStateUpdated?.Invoke();
            }
        }
        #endregion


        public void SetFreeState(bool value) => FreeState = value;
    }
}