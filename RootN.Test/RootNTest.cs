using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RootN;

namespace RootN.Test
{
    [TestClass]
    public class RootNTest
    {
        [TestMethod]
        public void Positive1()
        {
            Assert.AreEqual((int)Root.FindRoot(999.0, 3, 7) * 100, (int)Math.Pow(999.0, 1.0 / 3)*100);
        }

        [TestMethod]
        public void Positive2()
        {
            Assert.AreEqual((int)Root.FindRoot(999.0, 2, 7) * 100, (int)Math.Pow(999.0, 1.0 / 2) * 100);
        }

        [TestMethod]
        public void Positive3()
        {
            Assert.AreEqual((int)Root.FindRoot(-999.0, 3, 7) * 100, (int)Math.Pow(999.0, 1.0 / 3) * -100);
        }

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual((int)Root.FindRoot(0, 3, 7) * 100, (int)Math.Pow(0, 1.0 / 3) * 100);
        }

        [TestMethod]
        public void nLessZero()
        {
            try
            {
                Root.FindRoot(999, -3, 7);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "Степень должна быть положительная");
            }
        }

        [TestMethod]
        public void NoDecision()
        {
            try
            {
                Root.FindRoot(-225, 2, 7);
            }
            catch (InvalidOperationException e)
            {
                StringAssert.Contains(e.Message, "Нет решения");
            }
        }
    }
}
