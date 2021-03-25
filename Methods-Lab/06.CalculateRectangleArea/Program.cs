using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static double CalculatingArea(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculatingArea(width, height);

            Console.WriteLine(area);        
        }
    }
}
