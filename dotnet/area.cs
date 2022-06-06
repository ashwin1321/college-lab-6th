using System;
namespace shapes
{
    class Shapes
    {
        public float length { get; set; }
        public float width { get; set; }

        public float height { get; set; }

        public Shapes()
        {

        }

        public Shapes(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public Shapes(float length, float width, float height)
        {
            this.length = length;
            this.width = width;
            this.height = height;

        }

        public float reactangle()
        {
            Console.WriteLine("the area of rectangle is: ");
            if (height == 0)
            {
                return length * width;
            }
            return 2 * (length * width) + 2 * (width * height) + 2 * (length * height);
        }
        public float circle()
        {
            Console.WriteLine("he area of circle is: ");
            return (float)(2 * 3.14 * length);

        }



        public static class values
        {
            static void Main(string[] args)
            {
                var area = new Shapes(34, 53, 13);
                Console.WriteLine(area.reactangle());
                Console.WriteLine(area.circle());
            }
        }
        
    }
}