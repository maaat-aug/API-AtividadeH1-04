using AttH1.Services;

namespace AttH1
{
    public static class DependencyInjection
    {
        public static void AddDependency(this IServiceCollection services)
        {
            AddRepository(services);
        }
        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IAlunoRepository, AlunoRepository>();
        }
    }
}
