using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class WindowView : View
    {
        [SerializeField] private ButtonView button;

        public ButtonView Button => button;
    }
}
