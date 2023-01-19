using System;

namespace Cooking.Level
{
    public class GameplayManager : Singleton<GameplayManager>
    {
        public event Action GameplayStarted;

        public void StartGameplay()
        {
            GameplayStarted?.Invoke();
        }

        public void FinishGameplay()
        {

        }
    }
}