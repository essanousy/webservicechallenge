using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebServiceChallenge.Tests
{
    [TestClass()]
    public class FibonacciCalculTests
    {
        [TestMethod()]
        public void GetFibonacci_Test0()
        {
           
            var value = FibonacciCalcul.GetFibonacci(0);

            Assert.AreEqual(value, (Int64)0);
        }
        [TestMethod()]
        public void GetFibonacci_Test1()
        {
           
            var value = FibonacciCalcul.GetFibonacci(1);

            Assert.AreEqual(value, (Int64)1);
        }

        [TestMethod()]
        public void GetFibonacci_Test2()
        {
           
            var value = FibonacciCalcul.GetFibonacci(2);

            Assert.AreEqual(value, (Int64)1);
        }

        [TestMethod()]
        public void GetFibonacci_Test9()
        {
           
            var value = FibonacciCalcul.GetFibonacci(9);

            Assert.AreEqual(value, (Int64)34);
        }

        [TestMethod()]
        public void GetFibonacci_Test100()
        {
           
            var value = FibonacciCalcul.GetFibonacci(100);

            Assert.AreEqual(value, (Int64)3736710778780434371);
        }


    }
}