using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    public abstract class Controller<TModel>
        where TModel: Model
    {
        protected TModel model;

        public void SetModel(TModel model)
        {
            this.model = model;
        }
    }
}
