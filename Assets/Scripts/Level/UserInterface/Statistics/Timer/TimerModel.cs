using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class TimerModel : Model
    {
        public event Action<string> TimeUpdated;

        #region Time
        private string time;
        public string Time
        {
            get { return time; }
            set 
            { 
                time = value;
                TimeUpdated?.Invoke(time);
            }
        }
        #endregion


        public void SetTime(string value)
        {
            Time = value;
        }
    }
}