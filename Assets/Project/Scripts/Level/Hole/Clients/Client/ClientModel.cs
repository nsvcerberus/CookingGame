namespace Cooking.Level.Hole
{
    public class ClientModel : Model
    {
        private const float speed = 2;

        public ReceptionController OrderPlace { get; private set; }

        public void SetOrderPlace(ReceptionController orderPlace) => OrderPlace = orderPlace;

        public float Speed => speed;
    }
}