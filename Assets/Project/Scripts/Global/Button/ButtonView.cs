using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    public class ButtonView //: View
    {
        public event Action Click;

        public void OnClick() => Click?.Invoke();
    }
}