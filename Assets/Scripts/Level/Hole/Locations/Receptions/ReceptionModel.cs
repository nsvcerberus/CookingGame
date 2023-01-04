using System;

namespace Cooking.Level.Hole
{
    public class ReceptionModel : Model
    {
        public event Action FreeStateUpdated;

        public bool FreeState { get; private set; }

        public void OnFreeStateUpdated(bool value) => FreeState = value;
    }
}