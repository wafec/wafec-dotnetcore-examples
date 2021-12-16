using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.LocalFunctionsOrNestedFunctions
{
    public class LocalFunctionsOrNestedFunctionsDemo : IDemo
    {
        public void Run()
        {
            SimpleExample();
            Console.WriteLine($"Factorial of 5 is  {Factorial(5)}.");
        }

        private void SimpleExample()
        {
            int x = 10;
            int y = 20;

            int Add(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine($"Add {x} + {y} = {Add(x, y)}");
        }

        private long Factorial(int number)
        {
            long result = number;
            while (number > 1)
            {
                Multiply(number - 1);
                number--;
            }
            void Multiply(int x) => result *= x;
            return result;
        }
    }
}
