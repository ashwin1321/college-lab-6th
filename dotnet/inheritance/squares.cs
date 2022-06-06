using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes2
{
    public class Square: Shape
    {
        public Square(double length) { Side = length; }
        public double Side { get; }
        public override double Area {  get { return Math.Pow(Side,2); } }   

        public override double Perimeter { get { return Side * 4; } }
        public double Diagonal { get {  return Math.Round(Math.Sqrt(2)*Side,2); } }

    }
}
