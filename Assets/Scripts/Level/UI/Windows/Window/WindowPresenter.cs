using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UI
{
    public class WindowPresenter //: Controller<WindowView, Model>
    {
        public ButtonPresenter Button { get; private set; }


        public WindowPresenter(WindowView view) //: base(view)
        {
            Button = new ButtonPresenter(view.Button);
        }
    }
}