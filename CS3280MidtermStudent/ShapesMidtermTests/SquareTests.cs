using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesMidterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMidterm.Tests {
    [TestClass()]
    public class SquareTests {
        Square mySquare = new Square(2);

        [TestMethod()]
        public void SquareAreaTest()
        {
            Assert.AreEqual(mySquare.Area, 4);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Random random = new Random();
            double rand = random.NextDouble();
            mySquare = new Square(rand);
            string expected = $"Square: Side = {rand}";
            Assert.AreEqual(mySquare.ToString(), expected);
        }
    }
}