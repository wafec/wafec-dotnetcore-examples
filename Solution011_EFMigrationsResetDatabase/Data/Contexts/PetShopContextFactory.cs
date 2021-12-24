using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    public class PetShopContextFactory : IDesignTimeDbContextFactory<PetShopContext>
    {
        public PetShopContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PetShopContext>();
            string connectionString = Environment.GetEnvironmentVariable("ConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
            return new PetShopContext(optionsBuilder.Options);
        }
    }
}
