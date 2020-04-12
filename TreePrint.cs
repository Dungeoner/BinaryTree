using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreePrint<T> where T : IComparable
    {
        public void Print(Tree<T> tree)
        {
            Console.WriteLine("Tree  print:");
            print(tree.RootNode);
        }

        private void print(Node<T> node, string path = null)
        {
            if (node != null) Console.WriteLine("{0}{1}", path, node.NodeValue.ToString());
            if (node.Right != null)
            {
                string pathR = path + "R ";
                print(node.Right, pathR);
                
            }

            if (node.Left != null)
            {
                string pathL = path + "L ";
                print(node.Left, pathL);
            }
            
        }
    }
}
