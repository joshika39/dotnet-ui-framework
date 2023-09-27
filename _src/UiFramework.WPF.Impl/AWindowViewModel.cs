using System;
using UiFramework.Shared;

namespace UiFramework.WPF.Impl
{
    public abstract class AWindowViewModel<T> : IWindowViewModel<T> where T : IWindow<T>
    {
        public IWindow<T> Window { get; }
        
        protected AWindowViewModel(IWindow<T> window)
        {
            Window = window ?? throw new ArgumentNullException(nameof(window));
        }
    }
}
