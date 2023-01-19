using UnityEngine;

namespace Cooking
{
    public abstract class View<TController, TModel> : MonoBehaviour
        where TController: Controller<TModel>, new()
        where TModel : Model, new()
    {
        protected TController controller;
        protected TModel model;

        private void Awake()
        {
            model = new TModel();
            var controller = new TController();
            controller.SetModel(model);
        }
    }
}