using Microsoft.Extensions.DependencyInjection;
using Mniak.AspNetCore.Http.Abstractions;
using Mniak.AspNetCore.Http.Internal;

namespace Microsoft.AspNetCore.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServicesFromRequest(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IServiceFromRequest<>), typeof(ServiceFromRequest<>));
            return services;
        }
    }
}
