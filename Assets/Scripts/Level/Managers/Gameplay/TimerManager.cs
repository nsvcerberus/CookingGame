using System;
using UnityEngine;

namespace Cooking.Level
{
    public class TimerManager : Singleton<TimerManager>
    {
        public event Action<int> TimerUpdated;

        [SerializeField] private int time = 60;
        [SerializeField] private int interval = 1;
        private int timer;

        private void Start()
        {
            GameplayManager.instance.GameplayStarted += StartTimer;
        }

        public void StartTimer()
        {
            OnTimerUpdated(time);
            InvokeRepeating("DecreaseTimerValue", time, interval);
        }

        private void DecreaseTimerValue()
        {
            var value = timer - interval;
            OnTimerUpdated(value);

            if (value <= 0)
            {
                GameplayManager.instance.FinishGameplay();
            }
        }

        private void OnTimerUpdated(int value) => TimerUpdated.Invoke(timer = value);
    }
}