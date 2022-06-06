using System;

namespace shapes2
{
    class Program
    {
        // https://docs.microsoft.com

        static void Main()
        {
            Console.WriteLine("Hello, we are exploring Inheritance in Class");
            Shape[] shapes = { new Rectangle(10, 12), new Square(5), /*new Circle(3)*/ };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)};" + $"Perimeter, {Shape.GetPerimeter(shape)}");

                if(shape is Rectangle rect)
                {
                    Console.WriteLine($" Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }

                if (shape is Square sq)
                {
                    Console.WriteLine($" Diagonal: {sq.Diagonal}");
                    continue;
                }
                //Console.WriteLine(shape.Area);
            }
            
        }
    }
}
