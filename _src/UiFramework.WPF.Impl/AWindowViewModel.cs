using System;
using UiFramework.Shared;

namespace UiFramework.WPF.Impl
{
    public abstract class AWindowViewModel : IWindowViewModel
    {
        public IWindow Window { get; }
        
        protected AWindowViewModel(IWindow window)
        {
            Window = window ?? throw new ArgumentNullException(nameof(window));
        }
    }
}
