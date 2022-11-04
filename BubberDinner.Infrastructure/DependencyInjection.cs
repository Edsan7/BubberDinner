using BubberDinner.Application.Common;
using BubberDinner.Application.Common.Services;
using BubberDinner.Infrastructure.Authentication;
using BubberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            return services;
        }
        
}
}