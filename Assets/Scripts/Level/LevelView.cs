using System;
using UnityEngine;
using Cooking.Level.Hole;
using Cooking.Level.Table;
using Cooking.Level.UserInterface;

namespace Cooking.Level
{
    public class LevelView : View
    {
        [SerializeField] private TimerCoroutine timerCoroutines;
        [SerializeField] private HoleView hole;
        [SerializeField] private TableView table;
        [SerializeField] private UserInterfaceView userInterface;

        public TimerCoroutine TimerCoroutines => timerCoroutines;
        public HoleView Hole => hole;
        public TableView Table => table;
        public UserInterfaceView UserInterface => userInterface;
    }
}