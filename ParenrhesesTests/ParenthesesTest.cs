using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parentheses;

namespace ParenrhesesTests
{
    [TestClass]
    public class ParenthesesTest
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            string s = "";
            bool expected = false;
            Paren p = new Paren();
            bool actual = p.IsValid(s);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NullInputTest()
        {
            string s = null;
            bool expected = false;
            Paren p = new Paren();
            bool actual = p.IsValid(s);

            Assert.AreEqual(expected, actual);
        }

        [DataRow("[]") ]
        [DataRow("()[]{}") ]
        [DataRow("({})[()]{}") ]
        [DataRow("((()))[][]{{}}") ]
        [DataRow("{{{{}}}}") ]
        [DataTestMethod]
        public void ValidStringTest(string s)
        {
            Paren p = new Paren();
            var responce = p.IsValid(s);

            Assert.AreEqual(responce, true);
        }

        [DataRow("][")]
        [DataRow("]")]
        [DataRow("()[{]{}")]
        [DataRow("[})[()]{}")]
        [DataRow("(((])){][]{{}}")]
        [DataRow("{{{{)(}}}")]
        [DataTestMethod]
        public void InvalidStringTest(string s)
        {
            Paren p = new Paren();
            var responce = p.IsValid(s);

            Assert.AreEqual(responce, false);
        }
    }
}
