using NihonFinance.Services;
using NihonFinance.Services.Contracts;

namespace NihonFinance.Extensions
{
    public static class DependeciesExtension
    {
        public static void AddRepository(this IServiceCollection services)
        {
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();

        }
    }
}