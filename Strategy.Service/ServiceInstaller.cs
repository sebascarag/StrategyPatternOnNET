using Microsoft.Extensions.DependencyInjection;
using Strategy.Service.Contracts;

namespace Strategy.Service
{
    public static class ServiceInstaller
    {
        public static void AddStrategyService(this IServiceCollection services)
        {
            //services.AddTransient<IStrategy, ToUpperStrategy>();
            //services.AddTransient<IStrategy, ToLowerStrategy>();
            //services.AddTransient<IStrategy, ReverseStrategy>();

            var strategies = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(IStrategy).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

            foreach (var strategy in strategies)
            {
                services.AddTransient(
                    typeof(IStrategy),
                    strategy);
            }
        }
    }
}