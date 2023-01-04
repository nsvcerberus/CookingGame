namespace Cooking.Level.UI
{
    public class WindowsPresenter //: Controller<WindowsView, Model>
    {
        public WindowPresenter GameOver { get; private set; }
        public WindowPresenter Victory { get; private set; }


        public WindowsPresenter(WindowsView view) //: base(view)
        {
            GameOver = new WindowPresenter(view.GameOver);
            Victory = new WindowPresenter(view.Victory);

            //GameOver.Deactivate();
            //Victory.Deactivate();
        }
    }
}