using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.Write("Enter the value x1 :");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y1 :");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value x2 :");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y2 :");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line : " + length);
        }
    }
}
