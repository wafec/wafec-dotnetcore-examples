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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PetShop011;Trusted_Connection=True");
            return new PetShopContext(optionsBuilder.Options);
        }
    }
}
