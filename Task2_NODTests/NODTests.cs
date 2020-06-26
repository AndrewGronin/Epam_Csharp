using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Task2NOD.Tests
{
    [TestClass()]
    public class NODTests
    {
        [TestMethod()]
        public void GetNODTest_CorrectResults_2numbers()
        {
            int a = 10;
            int b = 15;

            int res = NOD.GetNOD(a,b);
            
            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODTest_CorrectResults_3numbers()
        {
            int a = 10;
            int b = 15;
            int c = 20;

            int res = NOD.GetNOD(a, b, c);

            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODTest_CorrectResults_4numbers()
        {
            int a = 10;
            int b = 15;
            int c = 20;
            int d = 25;

            int res = NOD.GetNOD(a, b, c, d);

            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODTest_CorrectResults_5numbers()
        {
            int a = 10;
            int b = 15;
            int c = 20;
            int d = 25;
            int e = 30;

            int res = NOD.GetNOD(a, b, c, d, e);

            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODBinaryTest_CorrectResults_2numbers()
        {
            int a = 10;
            int b = 15;

            int res = NOD.GetNODBinary(a, b);

            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODBinaryTestWithTime_CorrectResults_2numbers()
        {
            int a = 10;
            int b = 15;
            TimeSpan t;

            int res = NOD.GetNODBinaryWithTime(a, b ,out t);

            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODTestWithTime_CorrectResults_2numbers()
        {
            int a = 10;
            int b = 15;
            TimeSpan t;

            int res = NOD.GetNODWithTime(a, b, out t);

            Assert.AreEqual(res, 5);
        }

        [TestMethod()]
        public void GetNODBinaryTest_CorrectResults_Zeros()
        {
            int a = 0;
            int b = 15;

            int res = NOD.GetNODBinary(a, b);

            Assert.AreEqual(res, b);
        }

        [TestMethod()]
        public void GetNODTest_CorrectResults_Zeros()
        {
            int a = 0;
            int b = 15;

            int res = NOD.GetNOD(a, b);

            Assert.AreEqual(res, b);
        }

    }
}