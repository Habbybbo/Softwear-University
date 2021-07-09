using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;

        public double Length
        {
            get { return length; }
            
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                    
                }

                length = value;
            }
        }

        private double width;

        public double Width
        {
            get { return width; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            
            Length = length;
            Width = width;
            Height = height;
        }

        public void SurfaceArea()
        {
            double surfaceArea = ((Length * Width) * 2) + ((Length * Height) * 2) + ((Width * Height) * 2);

            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
        }

        public void LateralSurfaceArea()
        {
            double lateralSurfaceArea = ((Length * Height) * 2) + ((Width * Height) * 2);

            
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");

        }

        public void Volume()
        {
            double volume = Length * Width * Height;

            Console.WriteLine($"Volume - {volume:F2}");
        }



    }
}
