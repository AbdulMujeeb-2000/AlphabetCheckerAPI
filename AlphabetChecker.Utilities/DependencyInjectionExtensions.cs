using AlphabetCheckerAPI.Utilities.Contracts;
using AlphabetCheckerAPI.Utilities.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AlphabetCheckerAPI.Utilities
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AlphabetCheckerAPIUtilitiesService(this IServiceCollection services)
        {
            services.AddScoped<IAlphabetCheckerService, AlphabetCheckerService>();
            return services;
        }
    }
}
