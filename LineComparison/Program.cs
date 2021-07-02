using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line1 = new Line("line1");
            Line line2 = new Line("line2");
            Console.Write("Enter the value x1 for line1 :");
            line1.x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y1 for line1 :");
            line1.y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value x2 for line1 :");
            line1.x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y2 for line1 :");
            line1.y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value x1 for line2:");
            line2.x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y1 for line2 :");
            line2.y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value x2 for line2 :");
            line2.x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value y2 for line2 :");
            line2.y2 = Convert.ToInt32(Console.ReadLine());
            line1.lengthOfTheLine = Math.Sqrt(Math.Pow(line1.x2 - line1.x1, 2) + Math.Pow(line1.y2 - line1.y1, 2));
            line2.lengthOfTheLine = Math.Sqrt(Math.Pow(line2.x2 - line2.x1, 2) + Math.Pow(line2.y2 - line2.y1, 2)) ;
            int line_comparison = line1.lengthOfTheLine.CompareTo(line2.lengthOfTheLine);
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
