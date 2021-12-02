using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.DefaultInterfaceMethods
{
    public class DefaultInterfaceMethodsDemo : IDemo
    {
        public void Run()
        {
            IWriteLine instance = new WriteLineImpl();

            instance.WriteLine();
        }
    }
}
