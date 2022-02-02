using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Circle1_Radius_0()
        {
            Circle circle = new Circle(0);

        }

        [TestMethod()]
        public void Circle2_Radius_Normal()
        {
            Circle circle = new Circle(20);
            var area = Math.PI * 20 * 20;

            Assert.AreEqual(area, circle.Area());
        }
        [TestMethod()]
        public void Circle3_Radius_Negative()
        {
            Circle circle = new Circle(-20);
            var area = Math.PI * (-20) * (-20);

            Assert.AreEqual(area, circle.Area());
        }

        [TestMethod()]
        public void Circle4_Radius_Very_Big_Value()
        {
            Circle circle = new Circle(double.PositiveInfinity);

        }

    }
}