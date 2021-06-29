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
            Console.Write("Enter the value x3 :");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y3 :");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value x4 :");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y4 :");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length_in_line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length_in_line2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            int line_comparison = length_in_line1.CompareTo(length_in_line2);
            if(line_comparison==0)
            {
                Console.WriteLine("Lines are equal in length");
            }
            else if(line_comparison>0)
            {
                Console.WriteLine("Line1 is greater in length than Line2");
            }
            else
            {
                Console.WriteLine("Line1 is smaller in length than Line2");
            }
        }
    }
}
