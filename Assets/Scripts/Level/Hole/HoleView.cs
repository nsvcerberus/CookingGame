using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cooking.Level.Hole.Clients;
using Cooking.Level.Hole.Places;

namespace Cooking.Level.Hole
{
    public class HoleView : View
    {
        [SerializeField] private PlacesView places;
        [SerializeField] private ClientsView clients;

        public PlacesView Places => places;
        public ClientsView Clients => clients;
    }
}