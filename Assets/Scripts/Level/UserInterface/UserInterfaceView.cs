using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class UserInterfaceView : View
    {
        [SerializeField] private StatisticsView statistics;
        [SerializeField] private WindowsView windows;

        public StatisticsView Statistics => statistics;
        public WindowsView Windows => windows;
    }
}