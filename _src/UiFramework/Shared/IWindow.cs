namespace UiFramework.Shared
{
    public interface IWindow<out T> : IView
    {
        void Show();
        T GetWindow();
    }
}
