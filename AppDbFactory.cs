using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTest
{
    public static class AppDbFactory
    {
        public static void AddInMemoryDatabase(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("RessursPlan"));
        }
    }
}
