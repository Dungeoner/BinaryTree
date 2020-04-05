using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreePrint<T> where T : IComparable
    {
        public void Print(Tree<T> tree)
        {
            Print(tree.RootNode);
        }

        public void Print(Node<T> node)
        {
            Console.WriteLine("Tree print:");
            if (node != null) Console.WriteLine(node.NodeValue.ToString());
            if (node.Right != null) Print(node.Right);
            if (node.Left != null) Print(node.Left);
            
        }
    }
}
