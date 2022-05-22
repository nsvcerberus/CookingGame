using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Table
{
    public class DisheSourceView : View
    {
        [SerializeField] private ButtonView button;

        public ButtonView Button => button;
    }
}