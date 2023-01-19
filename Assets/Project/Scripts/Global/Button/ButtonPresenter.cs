using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    public class ButtonPresenter //: Controller<ButtonView, Model>
    {
        public event Action Click;

        public ButtonPresenter(ButtonView view) //: base(view)
        {
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            //view.Click += () => Click?.Invoke();
        }
    }
}