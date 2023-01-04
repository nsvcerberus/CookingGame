using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UI
{
    public class WindowsView : MonoBehaviour
    {
        [SerializeField] private WindowView gameOver;
        [SerializeField] private WindowView victory;

        public WindowView GameOver => gameOver;
        public WindowView Victory => victory;
    }
}