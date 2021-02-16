using System;
namespace FactoryPatternPractice_Polymorphism
{
    public class Square : IShapeArea
    {
        public Square()
        {
            Length = 1;
            Width = 1;
        }
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Math.Pow(Width, Length);
        }
        public double Area(double len, double wid)
        {
            return Math.Pow(len, wid);
        }
    }
}
