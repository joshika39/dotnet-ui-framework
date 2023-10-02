using UiFramework.Shared;

namespace UiFramework.Forms.Impl
{
    public abstract class AWindowPresenter : IWindowPresenter
    {
        public IWindow Window { get; }

        protected AWindowPresenter(IWindow window)
        {
            Window = window ?? throw new ArgumentNullException(nameof(window));
        }
    }
}
