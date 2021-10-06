using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;
using System;

namespace ReverseStringTests
{
    [TestClass]
    public class ReverseTests
    {

        [DataRow("test", "tset")]
        [DataRow("1234Aa", "aA4321")]
        [DataRow("rev erse", "esre ver")]
        [DataTestMethod]
        public void StringReverseTest(string input, string output)
        {
            string response = ReverseStr.Reverse(input);
            Assert.AreEqual(response, output);
        }

        [DataRow("test123", "321tset")]
        [DataRow("bB4321", "1234Bb")]
        [DataRow("rev erse", "esre ver")]
        [DataTestMethod]
        public void ReverseNewStringReverseTest(string input, string output)
        {
            string response = ReverseStr.ReverseNew(input);
            Assert.AreEqual(response, output);
        }

        [DataRow("test123", "321tset")]
        [DataRow("bB4321", "1234Bb")]
        [DataRow("rev erse", "esre ver")]
        [DataTestMethod]
        public void ReverseXORTest(string input, string output)
        {
            string responce = ReverseStr.ReverseXOR(input);
            Assert.AreEqual(responce, output);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void EmptyStringReverseXor()
        {
            string reverseTo = "";
            ReverseStr.ReverseXOR(reverseTo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void NullINputReverseXOR()
        {
            string reverseTo = null;
            ReverseStr.ReverseXOR(reverseTo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void EmptyStringTest()
        {
            string reverseTo = "";
            ReverseStr.Reverse(reverseTo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void NullInputTest()
        {
            string reverseTo = null;
            ReverseStr.Reverse(reverseTo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void ReverseNewEmptyStringTest()
        {
            string reverseTo = "";
            ReverseStr.ReverseNew(reverseTo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void ReverseNewNullInputTest()
        {
            string reverseTo = null;
            ReverseStr.ReverseNew(reverseTo);
        }

        

        
    }
}