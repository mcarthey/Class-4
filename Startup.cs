using Class_4.Dao;
using Class_4.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Class_4
{
    /// <summary>
    /// Install the following Nuget packages:
    ///     Microsoft.Extensions.Logging.Console
    ///     NReco.Logging.File
    /// </summary>
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // register services
            // https://www.c-sharpcorner.com/article/understanding-addtransient-vs-addscoped-vs-addsingleton-in-asp-net-core/
            services.AddLogging(builder =>
            {
                builder.AddConsole();
                builder.AddFile("app.log");
            });

            services.AddSingleton<IDataService, DataService>();
            services.AddSingleton<IDataDao, DatabaseDao>();
        }
    }
}
