using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cooking.Level;

namespace Cooking
{
    public class ApplicationView : View
    {
        [SerializeField] private LevelView level;

        private void Awake()
        {
            new ApplicationPresenter(this);
        }

        public LevelView Level => level;
    }
}