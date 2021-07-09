using System;

namespace ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {

            double lenght = double.Parse(Console.ReadLine());
            double wight = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            try
            {
                
                Box box = new Box(lenght, wight, hight);

                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch (ArgumentException)
            {
                if (lenght <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                }
                else if (wight <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                }
                else if (hight <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                }
            }
        }
    }
}
