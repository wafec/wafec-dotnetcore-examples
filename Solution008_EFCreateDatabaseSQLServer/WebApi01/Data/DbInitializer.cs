using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi01.Data.Contexts;

namespace WebApi01.Data
{
    // https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0#initialize-db-with-test-data
    public static class DbInitializer
    {
        public static void Initialize(PetShopContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
