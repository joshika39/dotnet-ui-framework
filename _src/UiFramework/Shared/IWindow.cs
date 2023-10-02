namespace UiFramework.Shared
{
    public interface IWindow : IView
    {
        void Show();
        DialogResult ShowOnTop();
    }
}
