using System;
using System.Linq;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dbFactory = new DbContext2Factory();
            var context = dbFactory.CreateDbContext(null);
            context.Context1Entity1s.Add(new Context2.Context1Entity1 { Description = "test2" });
            context.SaveChanges();
        }
    }
}
