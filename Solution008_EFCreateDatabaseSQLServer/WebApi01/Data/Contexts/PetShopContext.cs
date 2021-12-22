using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi01.Data.Entities;

namespace WebApi01.Data.Contexts
{
    public class PetShopContext : DbContext
    {
        public DbSet<PetEntity> Pets { get; set; }

        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }
    }
}
