using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parentheses;
using System;

namespace ParenrhesesTests
{
    [TestClass]
    public class ParenthesesTest
    {
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string should contain only parentheses!")]
        public void IsValidNotParenthesesInputTest()
        {
            string s = "(1%3.}";
            Paren p = new Paren();
            p.IsValid(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string should contain only parentheses!")]
        public void IsValidByStackNotParenthesesInputTest()
        {
            string s = "(1%3.}";
            Paren p = new Paren();
            p.IsValidByStack(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void IsValidEmptyStringTest()
        {
            string s = "";
            Paren p = new Paren();
            p.IsValid(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void IsValidByStackEmptyStringTest()
        {
            string s = "";
            Paren p = new Paren();
            p.IsValidByStack(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void IsValidNullInputTest()
        {
            string s = null;
            Paren p = new Paren();
            p.IsValid(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void IsValidByStackNullInputTest()
        {
            string s = null;
            Paren p = new Paren();
            p.IsValidByStack(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void IsValidOddStringTest()
        {
            string s = "{{}}}";
            Paren p = new Paren();
            p.IsValid(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input: Input string is null or empty!")]
        public void IsValidByStackOddStringTest()
        {
            string s = "((())";
            Paren p = new Paren();
            p.IsValidByStack(s);
        }

        [DataRow("[]") ]
        [DataRow("{{}}") ]
        [DataRow("()[]{}") ]
        [DataRow("({})[()]{}") ]
        [DataRow("((()))[][]{{}}") ]
        [DataRow("{{{{}}}}") ]
        [DataTestMethod]
        public void IsValidStringTest(string s)
        {
            Paren p = new Paren();
            var responce = p.IsValid(s);

            Assert.AreEqual(responce, true);
        }

        [DataRow("[]")]
        [DataRow("{{}}")]
        [DataRow("()[]{}")]
        [DataRow("({})[()]{}")]
        [DataRow("((()))[][]{{}}")]
        [DataRow("{{{{}}}}")]
        [DataTestMethod]
        public void IsValidByStackStringTest(string s)
        {
            Paren p = new Paren();
            var responce = p.IsValidByStack(s);

            Assert.AreEqual(responce, true);
        }

        [DataRow("][")]
        [DataRow("]}")]
        [DataRow("()[{]{}]")]
        [DataRow("[})[()]{}(")]
        [DataRow("(((])){][]{{}}")]
        [DataRow("{{{{)(}}}}")]
        [DataTestMethod]
        public void IsValidInvalidStringTest(string s)
        {
            Paren p = new Paren();
            var responce = p.IsValid(s);

            Assert.AreEqual(responce, false);
        }

        [DataRow("][")]
        [DataRow("]}")]
        [DataRow("()[{]{}]")]
        [DataRow("[})[()]{}(")]
        [DataRow("(((])){][]{{}}")]
        [DataRow("{{{{)(}}}}")]
        [DataTestMethod]
        public void IsValidByStackInvalidStringTest(string s)
        {
            Paren p = new Paren();
            var responce = p.IsValidByStack(s);

            Assert.AreEqual(responce, false);
        }
    }
}
