using System;
using System.Threading;

namespace Klasswork1
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Hello, " +name);
            Thread.Sleep(5000);
            Console.WriteLine("See you soon, " + name);
            Console.ReadKey();
        }
    }
}
