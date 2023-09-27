using UiFramework.Shared;

namespace UiFramework.Forms
{
    public interface IWindowPresenter<out T> where T : IWindow<T>
    {
        public T Window { get; }
    }
}
