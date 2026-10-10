using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() ?? "");
            int b = int.Parse(Console.ReadLine() ?? "");
            int c = int.Parse(Console.ReadLine() ?? "");
            int d = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");
        }
    }
}