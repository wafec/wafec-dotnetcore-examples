using Microsoft.EntityFrameworkCore;
using System;

namespace ProjectContext02
{
    public class Context02 : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Person> People { get; set; }

        public Context02() : base()
        {

        }

        public Context02(DbContextOptions<Context02> options) : base(options)
        {

        }
    }
}
