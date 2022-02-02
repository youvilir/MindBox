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
    public class TriangleTests
    {
        [TestMethod()]
        public void Triangle1_Sides_Normal()
        {

            Triangle triangle = new Triangle(3, 4, 5);
            double p = (3 + 4 + 5) / 2;
            var area = Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5));

            Assert.AreEqual(area, triangle.Area());
        }

        [TestMethod()]
        public void Triangle2_Sides_Zero()
        {
            Triangle triangle = new Triangle(0.0, 0.0, 0.0);
        }

        [TestMethod()]
        public void Triangle3_Sides_Negative()
        {
            Triangle triangle = new Triangle(-10, 10.0, 13.0);
        }

        [TestMethod()]
        public void Triangle4_Sides_Negative()
        {
            Triangle triangle = new Triangle(-10, -10.0, -13.0);
        }

        [TestMethod()]
        public void Triangle5_Rigth_Triangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(true, triangle.isRigthTriangle());
        }

        [TestMethod()]
        public void Triangle6_isExist()
        {
            Triangle triangle = new Triangle(1, 10, 15);

        }

        [TestMethod()]
        public void Triangle7_Not_Rigth_Triangle()
        {
            Triangle triangle = new Triangle(11, 10, 15);

            Assert.AreEqual(false, triangle.isRigthTriangle());

        }

        [TestMethod()]
        public void Triangle8_Very_Big_Value()
        {
            Triangle triangle = new Triangle(double.PositiveInfinity, 10, 15);


        }
    }
}