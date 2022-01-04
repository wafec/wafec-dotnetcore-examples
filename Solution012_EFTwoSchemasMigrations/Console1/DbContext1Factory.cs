using Context1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class DbContext1Factory : IDesignTimeDbContextFactory<DbContext1>
    {
        public DbContext1 CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext1>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=TestTwoSchemeMigrations;Trusted_Connection=Yes;", b =>
            {
                b.MigrationsAssembly("SqlServerMigrationsContext1");
                b.MigrationsHistoryTable("__Context1MigrationsHistory");
            });

            return new DbContext1(optionsBuilder.Options);
        }
    }
}
