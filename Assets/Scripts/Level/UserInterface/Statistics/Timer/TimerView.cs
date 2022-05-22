using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Cooking.Level.UserInterface
{
    public class TimerView : View
    {
        [SerializeField] private Text text;

        public void SetTime(string value) => text.text = value;
    }
}