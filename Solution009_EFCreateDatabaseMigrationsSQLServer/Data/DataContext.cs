using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<PersonEntity> People { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
