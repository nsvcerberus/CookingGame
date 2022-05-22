using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    public class Model
    {
		public event Action<bool> ActivityStateUpdated;

		private bool activityState;


		public void SetActivityState(bool value)
		{
			activityState = value;
			ActivityStateUpdated?.Invoke(activityState);
		}
    }
}