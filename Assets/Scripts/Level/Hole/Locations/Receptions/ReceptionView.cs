namespace Cooking.Level.Hole
{
    public class ReceptionView : View<ReceptionController, ReceptionModel>
    {
        private void Start()
        {
            GameplayManager.instance.GameplayStarted += InviteClient;
        }

        private void InviteClient()
        {
            OrdersManager.instance.InviteClient(transform.position);
        }
    }
}