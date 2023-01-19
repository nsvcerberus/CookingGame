using System;

namespace Cooking.Level.Hole
{
    public class ReceptionController : Controller<ReceptionModel>
    {
        public event Action<ReceptionController> Free;
        public event Action Busy;

        public ReceptionController()
        {
            
        }

        public void Start()
        {
            OnFree();
        }


        private void CheckState()
        {
            if (model.FreeState)
                OnFree();
            else
                OnBusy();
        }

        private void OnFree() => Free?.Invoke(this);
        private void OnBusy() => Busy?.Invoke();

        //public void SetFreeState() => model.SetFreeState(true);
        //public void SetNonFreeState() => model.SetFreeState(false);

        public bool GetFreeState() => model.FreeState;
        //public Vector3 GetPosition() => view.GetPosition();
    }
}