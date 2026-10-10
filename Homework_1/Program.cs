using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() ?? "");
            int b = int.Parse(Console.ReadLine() ?? "");
            int h = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine(a + b + 2 * Math.Sqrt(((a-b)/2) * ((a - b) / 2)  + h * h));
        }
    }
}