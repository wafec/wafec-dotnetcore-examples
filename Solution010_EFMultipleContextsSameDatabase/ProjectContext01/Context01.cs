using Microsoft.EntityFrameworkCore;
using System;

namespace ProjectContext01
{
    public class Context01 : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Person> People { get; set; }

        public Context01() : base()
        {

        }

        public Context01(DbContextOptions<Context01> options) : base(options)
        {

        }
    }
}
