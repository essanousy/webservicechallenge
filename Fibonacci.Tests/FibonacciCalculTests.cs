using Microsoft.VisualStudio.TestTools.UnitTesting;
using webservice_challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webservice_challenge.Tests
{
    [TestClass()]
    public class FibonacciCalculTests
    {
        [TestMethod()]
        public void GetFibonacci_Test0()
        {
            var fibCalcul = new FibonacciCalcul();
            var value = fibCalcul.GetFibonacci(0);

            Assert.AreEqual(value, (Int64)0);
        }
        [TestMethod()]
        public void GetFibonacci_Test1()
        {
            var fibCalcul = new FibonacciCalcul();
            var value = fibCalcul.GetFibonacci(1);

            Assert.AreEqual(value, (Int64)1);
        }

        [TestMethod()]
        public void GetFibonacci_Test2()
        {
            var fibCalcul = new FibonacciCalcul();
            var value = fibCalcul.GetFibonacci(2);

            Assert.AreEqual(value, (Int64)1);
        }

        [TestMethod()]
        public void GetFibonacci_Test9()
        {
            var fibCalcul = new FibonacciCalcul();
            var value = fibCalcul.GetFibonacci(9);

            Assert.AreEqual(value, (Int64)34);
        }

        [TestMethod()]
        public void GetFibonacci_Test100()
        {
            var fibCalcul = new FibonacciCalcul();
            var value = fibCalcul.GetFibonacci(100);

            Assert.AreEqual(value, (Int64)3736710778780434371);
        }


    }
}