﻿using UiFramework.Forms.Impl;
using UiFramework.Shared;

namespace UiFramework.Forms.Manual.Tests.Main
{
    public class MainWindowPresenter : AWindowPresenter, IMainWindowPresenter
    {
        public MainWindowPresenter(IMainWindow window) : base(window)
        { }
    }
}
