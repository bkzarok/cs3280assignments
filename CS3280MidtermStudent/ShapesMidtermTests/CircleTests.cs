using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesMidterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMidterm.Tests {
    [TestClass()]
    public class CircleTests {
        Circle myCircle = new Circle(3);

        [TestMethod()]
        public void CircleAreaTest()
        {
            double area = Math.Truncate(myCircle.Area * 1000) / 1000;
            Assert.AreEqual(area, 28.274d);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Random random = new Random();
            var rand = random.NextDouble();
            myCircle = new Circle(rand);
            string expected = $"Circle: Radius = {rand}";
            Assert.AreEqual(myCircle.ToString(), expected);
        }
    }
}