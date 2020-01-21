using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerService.API.Data
{
    public static class PrepareDatabase
    {
        public static void populateDatabase(IApplicationBuilder app){
            using(var serviceScope = app.ApplicationServices.CreateScope()){
                var context = serviceScope.ServiceProvider.GetService<DataContext>();
                context.Database.Migrate();
            }
        }
        
    }
}