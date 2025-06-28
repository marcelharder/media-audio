

using media_audio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace media_audio.Extensions;

    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

          
            var _connectionString = config.GetConnectionString("SQLConnection");
            services.AddDbContext<DataContext>(
                options => options.UseMySql(
                    _connectionString,
                    ServerVersion.AutoDetect(_connectionString)
                )
            );
        
          
           
            services.AddScoped<IAudio, Audio>();

           


          
            return services;
        }
    }
