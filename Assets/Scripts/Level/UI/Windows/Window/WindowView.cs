using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UI
{
    public class WindowView : MonoBehaviour
    {
        [SerializeField] private ButtonView button;

        public ButtonView Button => button;
    }
}
