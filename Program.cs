using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Primul numar: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Al doilea numar: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a,b,a+b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
    }
}
