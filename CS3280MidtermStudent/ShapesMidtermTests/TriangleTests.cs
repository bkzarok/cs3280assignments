using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesMidterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMidterm.Tests {
    [TestClass()]
    public class TriangleTests {
        Triangle myTriangle = new Triangle(2, 3);

        [TestMethod()]
        public void TriangleAreaTest()
        {
            Assert.AreEqual(myTriangle.Area, 3);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Random random = new Random();
            double rand = random.NextDouble();
            double rand2 = random.NextDouble();
            myTriangle = new Triangle(rand, rand2);
            string expected = $"Triangle: Height = {rand} and Base = {rand2}";
            Assert.AreEqual(myTriangle.ToString(), expected);
        }
    }
}