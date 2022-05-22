using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class WindowsPresenter : Presenter<WindowsView, Model>
    {
        public WindowPresenter GameOver { get; private set; }
        public WindowPresenter Victory { get; private set; }


        public WindowsPresenter(WindowsView view) : base(view)
        {
            GameOver = new WindowPresenter(view.GameOver);
            Victory = new WindowPresenter(view.Victory);

            GameOver.SetActivityState(false);
            Victory.SetActivityState(false);
        }
    }
}