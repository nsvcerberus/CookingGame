using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Table
{
    public class TableView : View
    {
        [SerializeField] private List<DisheSourceView> disheSources;

        public List<DisheSourceView> DisheSources => disheSources;
    }
}