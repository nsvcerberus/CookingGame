using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class TimerPresenter : Presenter<TimerView, TimerModel>
    {
        public TimerPresenter(TimerView view) : base(view)
        {
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            model.TimeUpdated += view.SetTime;
        }

        public void SetSeconds(int seconds)
        {
            TimeSpan timer = TimeSpan.FromSeconds(seconds);
            var time = string.Format("{0:D2}:{1:D2}",
                                      timer.Minutes,
                                      timer.Seconds);
            model.SetTime(time);
        }
    }
}