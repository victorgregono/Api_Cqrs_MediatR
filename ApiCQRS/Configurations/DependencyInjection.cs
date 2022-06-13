using MediatR;

namespace ApiCQRS.Configurations
{
    public static class DependencyInjection
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Program).Assembly);
        }
    }
}