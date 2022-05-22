using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Hole.Places
{
    public class EntryAndExitPlacesPresenter : Presenter<EntryAndExitPlacesView, EntryAndExitPlacesModel>
    {
        public EntryAndExitPlacesPresenter(EntryAndExitPlacesView view) : base(view)
        {
            DefinePositions();
        }

        private void DefinePositions()
        {
            if (view.Points.Count > 0)
            {
                for (int i = 0; i < view.Points.Count; i++)
                {
                    model.AddPosition(view.Points[i].position);
                }
            }
        }

        public Vector3 GetRandomPosition() => model.Positions[Random.Range(0, model.Positions.Count)];
    }
}