using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    public class PetShopContext : DbContext
    {
        public DbSet<PetEntity> Pets { get; set; }
        public DbSet<PetFoodEntity> PetFoods { get; set; }

        public PetShopContext() : base() { }

        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options)
        {

        }
    }
}
