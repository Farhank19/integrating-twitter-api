using twitter.DAO;
using twitter.Repository;

namespace twitter.Common
{
    public static class ServiceExtension
    {
        public static IServiceCollection BindingAppServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<UserDAO, UserRepository>();

            return services;
        }
    }
}
