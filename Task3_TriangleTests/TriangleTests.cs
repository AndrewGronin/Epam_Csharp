using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3_Triangle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Triangle.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTestCorrectInit()
        {
            Triangle t = new Triangle(1, 1.1, 1.2);

            Assert.AreEqual(t.a,1);
            Assert.AreEqual(t.b, 1.1);
            Assert.AreEqual(t.c, 1.2);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TriangleTestInCorrectInit()
        {       
           Triangle t = new Triangle(1, 1, 3);
           
        }

        [TestMethod()]
        public void CalculatePerimeterTest()
        {
            Triangle t = new Triangle(1, 1, 1);
            double p = t.CalculatePerimeter();

            Assert.AreEqual(p,3);
        }

        [TestMethod()]
        public void CalculateSquareTest()
        {
            Triangle t = new Triangle(3, 4, 5);//прямоугольный
            double s = t.CalculateSquare();

            Assert.AreEqual(s,6);
        }
    }
}