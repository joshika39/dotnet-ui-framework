namespace UiFramework.Forms
{
    public interface IView : Shared.IView
    {
        IViewPresenter Presenter { get; }
    }
}
