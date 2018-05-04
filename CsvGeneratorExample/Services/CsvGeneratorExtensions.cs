using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CsvGeneratorExample
{
    public static class CsvGeneratorExtensions
    {
        public static void AddCsvGenerator(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<ICsvGenerator, CsvGenerator>();
        }
    }
}
