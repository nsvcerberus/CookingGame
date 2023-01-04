using System;

namespace Cooking.Level
{
    public class GameplayManager : Singleton<GameplayManager>
    {
        public event Action GameplayStarted;


        void Start()
        {
            StartGameplay();
        }

        private void StartGameplay()
        {
            GameplayStarted?.Invoke();
        }

        public void FinishGameplay()
        {

        }
    }
}