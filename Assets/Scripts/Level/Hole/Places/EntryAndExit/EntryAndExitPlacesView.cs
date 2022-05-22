using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class EntryAndExitPlacesView : View
    {
        [SerializeField] private List<RectTransform> points;

        public List<RectTransform> Points => points;
    }
}