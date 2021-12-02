using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Tuples
{
    public class TuplesDemo : IDemo
    {
        public void Run()
        {
            var result = GetTupleExample();
            Console.WriteLine($"Tuple: {result}");
            (int x, int y) = result;
            Console.WriteLine($"x = {x}, y = {y}");
        }

        (int, int) GetTupleExample()
        {
            return (100, 500);
        }
    }
}
