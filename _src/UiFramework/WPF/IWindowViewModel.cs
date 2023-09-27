using UiFramework.Shared;

namespace UiFramework.WPF
{
    public interface IWindowViewModel<out T> : IViewModel where T : IWindow<T>
    {
        IWindow<T> Window { get; }
    }
}
