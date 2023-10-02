using UiFramework.Shared;

namespace UiFramework.WPF
{
    public interface IWindowViewModel : IViewModel
    {
        IWindow Window { get; }
    }
}
