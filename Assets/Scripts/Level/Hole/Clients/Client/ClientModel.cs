using Cooking.Level.Hole.Places;

namespace Cooking.Level.Hole.Clients
{
    public class ClientModel : Model
    {
        private const float speed = 2;

        public OrderPlacePresenter OrderPlace { get; private set; }

        public void SetOrderPlace(OrderPlacePresenter orderPlace) => OrderPlace = orderPlace;

        public float Speed => speed;
    }
}