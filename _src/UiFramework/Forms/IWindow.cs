namespace UiFramework.Forms
{
    public interface IWindow<out T> : Shared.IWindow where T : IWindowPresenter
    {
        T Presenter { get; }
    }
}
