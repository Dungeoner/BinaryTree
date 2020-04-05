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
            Console.WriteLine("Tree  print:");
            Print(tree.RootNode);
        }

        public void Print(Node<T> node, int i = 1)
        {
            if (node != null) Console.WriteLine(node.NodeValue.ToString());
            if (node.Right != null)
            {
                Console.WriteLine("R {0}", i);
                i++;
                Print(node.Right, i);
            }

            if (node.Left != null)
            {
                Console.WriteLine("L {0}", i);
                i++;
                Print(node.Left, i);
            }
            
        }
    }
}
