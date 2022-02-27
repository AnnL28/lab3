using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            RomanNumber n2 = (RomanNumber)n1.Clone();
            Assert.IsTrue(n1==n2);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            RomanNumber n2 = new RomanNumber(10);
            RomanNumber[] numbers = { n1, n2 };
            Array.Sort(numbers);
            Assert.AreEqual(numbers[0], n2);
            Assert.AreEqual(numbers[1], n1);
        }

        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            string s = n1.ToString();
            Assert.IsTrue(s == "XII");

            try
            {
                RomanNumber n2 = new RomanNumber(0);
                Assert.Fail("Нет исключений");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(RomanNumberException));
            }
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            RomanNumber n2 = new RomanNumber(24);
            Assert.IsTrue(n1+n1==n2);

            try
            {
                RomanNumber n3 = new RomanNumber(40000);
                RomanNumber n4 = n3 + n3;
                Assert.Fail("Нет исключений");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(RomanNumberException));
            }

        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            RomanNumber n2 = new RomanNumber(24);
            Assert.IsTrue(n2 - n1 == n1);

            try
            {
                RomanNumber n3 = new RomanNumber(1);
                RomanNumber n4 = n3 - n3;
                Assert.Fail("Нет исключений");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(RomanNumberException));
            }
        }

        [TestMethod()]
        public void MulTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            RomanNumber n2 = new RomanNumber(124);
            Assert.IsTrue(n1 * n1 == n2);

            try
            {
                RomanNumber n3 = new RomanNumber(1000);
                RomanNumber n4 = n3 * n3;
                Assert.Fail("Нет исключений");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(RomanNumberException));
            }
        }

        [TestMethod()]
        public void DivTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            RomanNumber n2 = new RomanNumber(124);
            Assert.IsTrue(n2 / n1 == n1);

            try
            {
                RomanNumber n3 = new RomanNumber(0);
                RomanNumber n4 = n3 / n3;
                Assert.Fail("Нет исключений");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(RomanNumberException));
            }
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            string s = n1.ToString();
            Assert.IsTrue(s == "XII");
        }
    }
}