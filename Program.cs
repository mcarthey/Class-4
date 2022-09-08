using Class_4.Dao;
using Class_4.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Class_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // First example from class: Exception Handling
            //ExceptionClass.ExampleMethod();

            // Second example from class: Interfaces

            // Register services, logging, interfaces
            IServiceCollection service = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(service);

            // moved from Main() to DataService class
            //IDataDao dao = new FileDao();
            //dao.Read();
            //dao.Write();

            // create service provider
            var serviceProvider = service.BuildServiceProvider();

            // get service and calling method
            var dataService = serviceProvider.GetService<IDataService>();
            dataService?.Invoke();
        }
    }
}
