using Microsoft.Extensions.DependencyInjection;
using UiFramework.Forms.Manual.Tests.Main;

namespace UiFramework.Forms.Manual.Tests;

public static class Program
{
    public static void Main()
    {
        var modules = LoadModules();
        var mainWindowPresenter = modules.GetService<IMainWindowPresenter>();
        Console.WriteLine(mainWindowPresenter?.Window.ShowOnTop());
    }

    private static IServiceProvider LoadModules()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<IMainWindow, MainWindow>();
        serviceCollection.AddTransient<IMainWindowPresenter, MainWindowPresenter>();
        return serviceCollection.BuildServiceProvider();
    }
}
