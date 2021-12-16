using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.BinaryLiterals
{
    public class BinaryLiteralsDemo : IDemo
    {
        public void Run()
        {
            int a = 50;
            int b = 0b110010;
            Console.WriteLine($"a: {a:0000} b: {b:0000}");
        }
    }
}
