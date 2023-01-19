using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole
{
    public class Locations 
    {
        [SerializeField] private List<RectTransform> points;

        public List<RectTransform> Points => points;
    }
}