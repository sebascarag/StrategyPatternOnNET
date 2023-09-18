using Microsoft.OpenApi.Models;
using Strategy.Api.Services;
using Strategy.Service.Contracts;

namespace Strategy.Api
{
    public static class StrategyApiInstaller
    {
        public static void AddStrategyApi(this IServiceCollection services)
        {
            services.AddTransient<IStrategyContext, StrategyContext>();
            services.AddCors(cors =>
                cors.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader())
            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2", new OpenApiInfo { Title = "EventManagmentApi", Version = "v2" });
            });
        }
    }
}
