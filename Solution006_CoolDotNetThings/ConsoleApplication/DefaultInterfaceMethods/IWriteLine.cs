using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.DefaultInterfaceMethods
{
    public interface IWriteLine
    {
        public void WriteLine()
        {
            Console.WriteLine("Wow");
        }
    }
}
