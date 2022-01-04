using Microsoft.EntityFrameworkCore;
using System;

namespace Context2
{
    public class DbContext2 : DbContext
    {
        public DbSet<Context2Entity1> Entity1s { get; set; }
        public DbSet<Context2Entity2> Entity2s { get; set; }
        public DbSet<Context1Entity1> Context1Entity1s { get; set; }

        public DbContext2(DbContextOptions<DbContext2> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Context1Entity1>().Metadata.SetIsTableExcludedFromMigrations(true);
        }
    }
}
