using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class PlacesView : View
    {
        [SerializeField] private EntryAndExitPlacesView entryAndExitPlaces;
        [SerializeField] private OrderPlacesView orderPlaces;

        public EntryAndExitPlacesView EntryAndExitPlaces => entryAndExitPlaces;
        public OrderPlacesView OrderPlaces => orderPlaces;
    }
}