using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class WindowsView : View
    {
        [SerializeField] private WindowView gameOver;
        [SerializeField] private WindowView victory;

        public WindowView GameOver => gameOver;
        public WindowView Victory => victory;
    }
}