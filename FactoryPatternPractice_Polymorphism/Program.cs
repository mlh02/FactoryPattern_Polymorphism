using System;

namespace FactoryPatternPractice_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Shape To Find Area \n" +
                "1 - Circle \n" +
                "2 - Square");
            int shapeAns = int.Parse(Console.ReadLine());
            if(shapeAns == 1)
            {
                Circle cirlce = new Circle();
                Console.WriteLine("Enter Radious Of Cirlce");
                double rad = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of your Circle is:" + cirlce.Area(rad)); 
            }
            else
            {
                Square cirlce = new Square();
                Console.WriteLine("Enter Length Of Square");
                double len = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width Of Square");
                double wid = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of your Square is: " + cirlce.Area(len, wid));
            }

            
        }
    }
}
