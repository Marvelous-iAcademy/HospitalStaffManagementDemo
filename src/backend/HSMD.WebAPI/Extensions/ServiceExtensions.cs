using LoggerService;

namespace HSMD.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });  // Handles deployment
       
            
        }
        public static void ConfigureLoggerServices(this IServiceCollection services)
        {
            services.AddScoped<LoggerManager, LoggerManager>();
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {

        }
    }
}
