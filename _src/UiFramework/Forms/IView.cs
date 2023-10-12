namespace UiFramework.Forms
{
    public interface IView <out T> : Shared.IView where T : IViewPresenter
    {
        T Presenter { get; }
    }
}
