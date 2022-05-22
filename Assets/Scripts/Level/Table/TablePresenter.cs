using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Table
{
    public class TablePresenter : Presenter<TableView, Model>
    {
        public List<DisheSourcePresenter> DisheSources { get; private set; }

        public TablePresenter(TableView view) : base(view)
        {
            DisheSources = new List<DisheSourcePresenter>();

            CreateDisheSources();
        }

        private void CreateDisheSources()
        {
            for (int i = 0; i < view.DisheSources.Count; i++)
            {
                DisheSources.Add(new DisheSourcePresenter(view.DisheSources[i]));
            }
        }
    }
}