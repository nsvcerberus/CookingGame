using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class UserInterfacePresenter : Presenter<UserInterfaceView, Model>
    {
        public StatisticsPresenter Statistics { get; private set; }
        public WindowsPresenter Windows { get; private set; }

        public UserInterfacePresenter(UserInterfaceView view) : base(view)
        {
            Statistics = new StatisticsPresenter(view.Statistics);
            Windows = new WindowsPresenter(view.Windows);
        }
    }
}