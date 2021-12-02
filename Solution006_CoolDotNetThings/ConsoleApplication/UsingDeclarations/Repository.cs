using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.UsingDeclarations
{
    public class Repository : IDisposable
    {
        public void SaveChanges()
        {
            Console.WriteLine("Saving changes");
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
