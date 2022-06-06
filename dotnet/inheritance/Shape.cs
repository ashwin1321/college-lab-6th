using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes2
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public override string ToString()
        {
            return GetType().Name;
        }

        public static double GetArea(Shape shape) { return shape.Area; }
        public static double GetPerimeter(Shape shape) { return shape.Perimeter; }
    }
}
