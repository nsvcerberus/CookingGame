using System;
//using System.Timers;
using UnityEngine;

namespace Cooking.Level.Gameplay
{
    public class TimerManager
    {
        public event Action<int> Updated;
        public event Action Ended;

        private TimerCoroutine timer;
        private int seconds;


        public void SetTimerCoroutine(TimerCoroutine timer)
        {
            this.timer = timer;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            timer.Updated += DecreaseSeconds;
        }


        public void Start()
        {
            SetSeconds(60);
            timer.Run();
        }

        private void DecreaseSeconds()
        {
            SetSeconds(--seconds);

            if (seconds == 0)
            {
                Stop();
                Ended?.Invoke();
            }
        }

        public void Stop()
        {
            timer.Stop();
        }


        private void SetSeconds(int value)
        {
            seconds = value;
            Updated?.Invoke(seconds);
        }


        /*
        public event Action<int> Updated;
        public event Action Ended;

        private int seconds;

        private Timer timer;


        public TimerManager()
        {
            timer = new Timer(1000);
            timer.Elapsed += OnUpdated;
        }

        public void Start()
        {
            seconds = 60;
            timer.Start();
        }

        private void OnUpdated(System.Object source, ElapsedEventArgs e)
        {
            seconds--;

            if (seconds == 0)
                OnEnded();

            Updated?.Invoke(seconds);
        }

        private void OnEnded()
        {
            Stop();
            Ended?.Invoke();
        }

        public void Stop() => timer.Stop();
        */
    }
}