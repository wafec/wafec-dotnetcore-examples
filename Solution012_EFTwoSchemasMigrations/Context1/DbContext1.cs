using Microsoft.EntityFrameworkCore;
using System;

namespace Context1
{
    public class DbContext1 : DbContext
    {
        public DbSet<Context1Entity1> Entity1s { get; set; }
        public DbSet<Context1Entity2> Entity2s { get; set; }

        public DbContext1(DbContextOptions<DbContext1> options) : base(options)
        {

        }
    }
}
