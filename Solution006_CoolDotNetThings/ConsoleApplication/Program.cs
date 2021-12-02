using ConsoleApplication.BinaryLiterals;
using ConsoleApplication.DefaultInterfaceMethods;
using ConsoleApplication.LocalFunctionsOrNestedFunctions;
using ConsoleApplication.Tuples;
using ConsoleApplication.UsingDeclarations;
using System;

namespace ConsoleApplication
{
    class Program
    {
        private static readonly IDemo[] demos = new IDemo[]
        {
            new DefaultInterfaceMethodsDemo(),
            new UsingDeclarationsDemo(),
            new LocalFunctionsOrNestedFunctionsDemo(),
            new BinaryLiteralsDemo(),
            new TuplesDemo()
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var demo in demos)
            {
                Console.WriteLine($"Demo: {demo.GetType().Name}");
                demo.Run();
                Console.WriteLine();
            }
        }
    }
}
