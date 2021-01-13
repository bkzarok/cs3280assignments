using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMidterm
{
    public class Triangle : Shape
    {
        public double base1;
        public double height;

        public double Base
        {


            get
            {
                return base1;
            }
            set
            {
                base1 = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set { height = value; }
        }
        public Triangle(double height, double base1)
            {
                Height = height; 
                Base = base1;
            }

       
        public override double Area => ((Height*Base)/2);

        public override string ToString()
        {
            return $"Triangle: Height = {Height} and Base = {Base}";
        }
    }
}
