namespace Cooking.Level.Hole.Places
{
    public class PlacesPresenter : Presenter<PlacesView, Model>
    {
        public EntryAndExitPlacesPresenter EntryAndExitPlaces { get; private set; }
        public OrderPlacesPresenter OrderPlaces { get; private set; }

        public PlacesPresenter(PlacesView view) : base(view)
        {
            EntryAndExitPlaces = new EntryAndExitPlacesPresenter(view.EntryAndExitPlaces);
            OrderPlaces = new OrderPlacesPresenter(view.OrderPlaces);

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            
        }
    }
}