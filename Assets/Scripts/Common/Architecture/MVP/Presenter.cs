using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    public abstract class Presenter<TView, TModel>
        where TView : View
        where TModel : Model, new()
    {
        protected TView view;
        protected TModel model;

        public Presenter(TView view)
        {
            this.view = view;
            model = new TModel();
            
            SubscribeToEvents();
            model.SetActivityState(true);
        }

        private void SubscribeToEvents()
        {
            model.ActivityStateUpdated += view.SetActive;
        }


        public void Activate() => model.SetActivityState(true);
        public void Deactivate() => model.SetActivityState(false);
    }
}
