using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine(Math.Cos(x));
        }
    }
}