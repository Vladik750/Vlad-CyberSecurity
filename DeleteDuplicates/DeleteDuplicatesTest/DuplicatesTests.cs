using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeleteDuplicatesTest;
using System.Collections.Generic;
using System;


namespace DeleteDuplicatesTest
{
    [TestClass]
    public class DuplicatesTests
    {
        [ExpectedException(typeof(ArgumentException),"Wrong input: empty list")]
        [TestMethod]
        public void ExceptionTest()
        {
            DeleteDuplicates.LinkList link = new DeleteDuplicates.LinkList();
            int[] arr = new int[] { };
            LinkedList<int> list = new LinkedList<int>(arr);

            link.DeleteDuplicates(list);
         
        }

        [TestMethod]
        public void DeleteDuplicateTest()
        {
            DeleteDuplicates.LinkList link = new DeleteDuplicates.LinkList();
            int[] arr = new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 4, 4 };
            LinkedList<int> list = new LinkedList<int>(arr);
            int[] expArr = new int[] { 1, 2, 3, 4 };
            LinkedList<int> expList = new LinkedList<int>(expArr);

            link.DeleteDuplicates(list);
            Assert.AreEqual(expList, expList);
        }

        [TestMethod]
        public void DeleteDuplicateTest1()
        {
            DeleteDuplicates.LinkList link = new DeleteDuplicates.LinkList();
            int[] arr = new int[] { 1 };
            LinkedList<int> list = new LinkedList<int>(arr);
            int[] expArr = new int[] { 1};
            LinkedList<int> expList = new LinkedList<int>(expArr);

            link.DeleteDuplicates(list);
            Assert.AreEqual(expList, expList);
        }

        [TestMethod]
        public void DeleteDuplicateTest2()
        {
            DeleteDuplicates.LinkList link = new DeleteDuplicates.LinkList();
            int[] arr = new int[] { 1, 2 };
            LinkedList<int> list = new LinkedList<int>(arr);
            int[] expArr = new int[] { 1, 2 };
            LinkedList<int> expList = new LinkedList<int>(expArr);

            link.DeleteDuplicates(list);
            Assert.AreEqual(expList, expList);
        }

        [TestMethod]
        public void DeleteDuplicateTest3()
        {
            DeleteDuplicates.LinkList link = new DeleteDuplicates.LinkList();
            int[] arr = new int[] {  4, 4, 4, 4 };
            LinkedList<int> list = new LinkedList<int>(arr);
            int[] expArr = new int[] { 4 };
            LinkedList<int> expList = new LinkedList<int>(expArr);

            link.DeleteDuplicates(list);
            Assert.AreEqual(expList, expList);
        }
    }
}
