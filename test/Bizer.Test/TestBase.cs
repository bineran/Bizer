using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bizer.Test;
public abstract class TestBase
{

    public TestBase()
    {
        Host.CreateDefaultBuilder().ConfigureServices(ConfigureServices).Build().WithBizer();
    }

    protected virtual void ConfigureServices(IServiceCollection services) { }

    protected IServiceProvider ServiceProvider => App.Services;

    protected T? GetService<T>() where T : class => ServiceProvider.GetService<T>();
}