using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.UsingDeclarations
{
    public class UsingDeclarationsDemo : IDemo
    {
        public void Run()
        {
            using Repository repo = new Repository();
            repo.SaveChanges();
            Console.WriteLine("TODO...");
        }
    }
}
