using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cooking.Level;

namespace Cooking
{
    public class ApplicationPresenter : Presenter<ApplicationView, Model>
    {
        private LevelPresenter level;

        public ApplicationPresenter(ApplicationView view) : base(view)
        {
            level = new LevelPresenter(view.Level);
        }
    }
}