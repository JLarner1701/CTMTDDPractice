using System;

namespace CTMTDDPractice.Shapes
{
    public class Circle
    {
        private readonly int _radius;
        private readonly double pi = Math.PI;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public double Circumference()
        {
            return Math.Round(2 * pi * _radius, 2);
        }


        public double Area()
        {
            return Math.Round(pi * _radius * _radius, 2);
        }
    }
}
