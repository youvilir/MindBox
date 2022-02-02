using NUnit.Framework;
using ShapeLibrary;
using System;

namespace CircleTests
{
    public class Tests
    {

        [Test]
        public void Circle1_Radius_0()
        {
            Circle circle = new Circle(0);
            
        }

        [Test]
        public void Circle2_Radius_Normal()
        {
            Circle circle = new Circle(20);
            var area = Math.PI * 20 * 20;

            Assert.AreEqual( area, circle.Area());
        }

        [Test]
        public void Circle3_Radius_Negative()
        {
            Circle circle = new Circle(-20);
            var area = Math.PI * (-20 )* ( -20 );

            Assert.AreEqual(area, circle.Area());
        }

        [Test]
        public void Circle4_Radius_Very_Big_Value()
        {
            Circle circle = new Circle(double.PositiveInfinity);

        }

    }
}