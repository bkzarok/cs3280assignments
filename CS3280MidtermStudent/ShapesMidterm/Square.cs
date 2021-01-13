using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMidterm
{
    public class Square : Shape
    {
        public double side;
        public Square(double side) => Side = side;
        public double Side {

            
            get {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public override double Area => Side*Side;

        public override string ToString()
        {
            return $"Square: Side = {Side}";
        }
    }
}
