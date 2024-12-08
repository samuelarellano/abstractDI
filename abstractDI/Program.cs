// Crea el host genérico
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vehicles;

var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                // Configura las dependencias.
                services.AddTransient<Vehicle, Motorcycle>(); 
                services.AddTransient<Driver>();
            })
            .Build();

using (var scope = host.Services.CreateScope())
        {
            var driver = scope.ServiceProvider.GetRequiredService<Driver>();
            driver.Operate();
        }

       
        await host.RunAsync();
