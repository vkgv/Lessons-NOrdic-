using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Console.WriteLine("Введите второе число");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}+{1}={2}", a, b, a - b);
            Console.WriteLine("{0}+{1}={2}", a, b, a * b);
            Console.ReadKey();
        }
    }
}
