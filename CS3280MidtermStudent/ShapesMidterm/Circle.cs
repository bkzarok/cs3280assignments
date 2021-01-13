using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMidterm
{
    public class Circle : Shape
    {
        public double radius;
        public double Radius
        {


            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(double radius) => Radius = radius;
        public override double Area => Math.PI * radius*radius;

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }
}
