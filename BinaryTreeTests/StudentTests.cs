using System;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void CompareToTest()
        {
            var student1 = new Student("A", "A", 20, 1);
            var student2 = new Student("A", "A", 20, 2);
            var student3 = new Student("A", "B", 20, 2);
            Assert.AreEqual(student1.CompareTo(student2), -1);
            Assert.AreEqual(student2.CompareTo(student3), -1);
        }
    }
}
