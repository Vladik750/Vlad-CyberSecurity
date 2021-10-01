using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;
using System;

namespace ReverseStringTests
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void StringReverseTest()
        {
            string reverseTo = "reverseTest";
            string expected = "tseTesrever";

            string actual = ReverseStr.Reverse(reverseTo);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StringReverseTest1()
        {
            string reverseTo = "ab";
            string expected = "ba";

            string actual = ReverseStr.Reverse(reverseTo);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverseTest2()
        {
            string reverseTo = "T";
            string expected = "T";

            string actual = ReverseStr.Reverse(reverseTo);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverseNewTest()
        {
            string reverseTo = "reverse";
            string expected = "esrever";

            string actual = ReverseStr.ReverseNew(reverseTo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverseNewTest1()
        {
            string reverseTo = "aBcD";
            string expected = "DcBa";

            string actual = ReverseStr.ReverseNew(reverseTo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExceptionTest()
        {
            try
            {
                ReverseStr.Reverse("");
                Assert.Fail();
            }
            catch (ArgumentException) { }
        }

        [TestMethod]
        public void ExceptionTest1()
        {
            try
            {
                ReverseStr.Reverse(null);
                Assert.Fail();
            }catch (ArgumentException) { }
        }
        
        [TestMethod]
        public void ExceptionTest2()
        {
            try
            {
                ReverseStr.ReverseNew(null);
                Assert.Fail();
            }catch (ArgumentException) { }
        }
        
        [TestMethod]
        public void ExceptionTest3()
        {
            try
            {
                ReverseStr.ReverseNew("");
                Assert.Fail();
            }catch (ArgumentException) { }
        }

    }
}
