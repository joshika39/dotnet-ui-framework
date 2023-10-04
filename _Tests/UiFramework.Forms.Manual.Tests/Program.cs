using Microsoft.Extensions.DependencyInjection;
using UiFramework.Forms.Manual.Tests.Main;

namespace UiFramework.Forms.Manual.Tests;

public static class Program
{
    public static void Main()
    {
        var modules = LoadModules();
        var window = modules.GetRequiredService<IMainWindow>();
        Console.WriteLine(window.ShowOnTop());
    }

    private static IServiceProvider LoadModules()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<IMainWindowPresenter, MainWindowPresenter>();
        serviceCollection.AddTransient<IMainWindow, MainWindow>();
        return serviceCollection.BuildServiceProvider();
    }
}
