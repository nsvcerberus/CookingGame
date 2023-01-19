using UnityEngine;

namespace Cooking.Level.UI
{
    public class BlackScreen : Window
    {
        private void Hidden()
        {
            GameplayManager.instance.StartGameplay();
        }
    }
}