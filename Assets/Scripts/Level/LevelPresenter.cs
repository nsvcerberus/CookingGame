using Cooking.Level.Hole;
using Cooking.Level.Table;
using Cooking.Level.UserInterface;
using Cooking.Level.Gameplay;

namespace Cooking.Level
{
    public class LevelPresenter : Presenter<LevelView, Model>
    {
        public HolePresenter Hole { get; private set; }
        public TablePresenter Table { get; private set; }
        public UserInterfacePresenter UserInterface { get; private set; }
        public GameplayManager Gameplay { get; private set; }


        public LevelPresenter(LevelView view) : base(view)
        {
            Hole = new HolePresenter(view.Hole);
            Table = new TablePresenter(view.Table);
            UserInterface = new UserInterfacePresenter(view.UserInterface);
            Gameplay = new GameplayManager();

            Gameplay.Timer.SetTimerCoroutine(view.TimerCoroutines);

            SubscribeToEvents();
            Start();
        }

        private void SubscribeToEvents()
        {            
            Gameplay.Clients.ClientsAmountUpdated += UserInterface.Statistics.Clients.SetClientsAmount;
            Gameplay.Clients.WaitingClientsAmountUpdated += UserInterface.Statistics.Clients.SetWaitingClientsAmount;
            Gameplay.Timer.Updated += UserInterface.Statistics.Timer.SetSeconds;
            Gameplay.Started += Hole.Start;

            Hole.CheckIfCanCreateNewClient += Gameplay.Clients.CheckIfCanCreateNewClient;
            Hole.Clients.ClientCreated += Gameplay.Clients.DecreaseWaitingClientsAmount;
        }

        private void Start()
        {
            Gameplay.Start();
        }
    }
}