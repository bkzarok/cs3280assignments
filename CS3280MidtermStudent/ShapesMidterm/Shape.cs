using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesMidterm
{
    // Create 3 subclasses of Shape: Triange, Circle and Square
    public abstract class Shape
    {
        // override this property in your shape subclasses
        public abstract double Area { get; }

        // override the ToString() method in your shape subclasses
        public abstract override string ToString();
    }
}
