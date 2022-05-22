using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.Table
{
    public class DisheSourcePresenter : Presenter<DisheSourceView, Model>
    {
        public ButtonPresenter Button { get; private set; }

        public DisheSourcePresenter(DisheSourceView view) : base(view)
        {
            Button = new ButtonPresenter(view.Button);

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            Button.Click += CheckIfDoneDish;
        }

        private void CheckIfDoneDish()
        {
            // проверить если блюдо готово и отдать его!
        }
    }
}
