using System;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void AddNodeTest()
        {
            var testTree = new Tree<int>();

            testTree.AddNode(2);
            testTree.AddNode(1);
            testTree.AddNode(3);

            Assert.AreEqual(testTree.RootNode.NodeValue, 2);
            Assert.AreEqual(testTree.RootNode.Right.NodeValue, 3);
            Assert.AreEqual(testTree.RootNode.Left.NodeValue, 1);
        }
    }
}
