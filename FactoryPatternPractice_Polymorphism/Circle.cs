using System;
namespace FactoryPatternPractice_Polymorphism
{
    public class Circle : IShapeArea
    {
        public Circle()
        {
            Radius = 0;
        }
        public double Radius { get; set; }

        public double Area()
        {
            return Radius * Math.PI * 2;
        }
        public double Area(double rad)
        {
            return rad * Math.PI * 2;
        }
    }
}
