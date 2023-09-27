using UiFramework.Shared;

namespace UiFramework.Forms.Impl
{
    public abstract class AWindowPresenter<T> : IWindowPresenter<T> where T : IWindow<T>
    {
        public T Window { get; }

        protected AWindowPresenter(T window)
        {
            Window = window ?? throw new ArgumentNullException(nameof(window));
        }
    }
}
