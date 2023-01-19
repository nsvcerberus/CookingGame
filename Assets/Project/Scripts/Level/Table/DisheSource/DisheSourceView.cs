using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Table
{
    public class DisheSourceView  : MonoBehaviour//: View
    {
        [SerializeField] private ButtonView button;

        public ButtonView Button => button;
    }
}