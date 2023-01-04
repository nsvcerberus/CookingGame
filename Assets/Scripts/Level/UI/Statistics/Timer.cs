using System;
using UnityEngine;
using TMPro;

namespace Cooking.Level.UI.Statistics
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;

        private void Start()
        {
            TimerManager.instance.TimerUpdated += SetTime;
        }

        public void SetTime(int value) {
            TimeSpan timer = TimeSpan.FromSeconds(value);
            var time = string.Format("{0:D2}:{1:D2}",
                                      timer.Minutes,
                                      timer.Seconds);
            text.text = time;
        }
    }
}