using Context2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    public class DbContext2Factory : IDesignTimeDbContextFactory<DbContext2>
    {
        public DbContext2 CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext2>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=TestTwoSchemeMigrations;Trusted_Connection=Yes;",
                b =>
                {
                    b.MigrationsAssembly("SqlServerMigrationsContext2");
                    b.MigrationsHistoryTable("__Context2MigrationsHistory");
                });

            return new DbContext2(optionsBuilder.Options);
        }
    }
}
