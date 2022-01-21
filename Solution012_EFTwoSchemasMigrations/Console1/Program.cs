using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dbFactory = new DbContext1Factory();
            var context = dbFactory.CreateDbContext(null);
            context.Entity1s.Add(new Context1.Context1Entity1 { Text = "test", Description = "test" });
            context.SaveChanges();
        }
    }
}
