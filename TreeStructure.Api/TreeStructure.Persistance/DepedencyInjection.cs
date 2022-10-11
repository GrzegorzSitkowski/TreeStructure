using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TreeStructure.Application.Common.Interfaces;

namespace TreeStructure.Persistance
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("TreeStructureDatabase")));

            services.AddScoped<IDataContext, DataContext>();
            return services;
        }
    }
}
