using Microsoft.Extensions.DependencyInjection;
using ShassiWPFApp.Persistence;
using ShassiWPFApp.Services;
using System.Windows;

namespace ShassiWPFApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private IServiceProvider ServiceProvider { get; set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        ServiceProvider = serviceCollection.BuildServiceProvider();

        var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();

        base.OnStartup(e);
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();

        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        services.AddSingleton<IHarnessService, HarnessService>();
        services.AddSingleton<MainWindow>();
    }

}