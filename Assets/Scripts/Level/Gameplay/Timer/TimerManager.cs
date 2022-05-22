using System;
using System.Timers;

namespace Cooking.Level.Gameplay
{
    public class TimerManager
    {
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
    }
}