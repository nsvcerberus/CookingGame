using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class EntryAndExitPlacesModel : Model
    {
        public List<Vector3> Positions { get; private set; }

        public EntryAndExitPlacesModel()
        {
            Positions = new List<Vector3>();
        }

        public void AddPosition(Vector3 position) => Positions.Add(position);
    }
}