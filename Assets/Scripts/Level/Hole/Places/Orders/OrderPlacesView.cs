using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class OrderPlacesView : View
    {
        [SerializeField] private List<OrderPlaceView> objects;

        public List<OrderPlaceView> Objects => objects;
    }
}