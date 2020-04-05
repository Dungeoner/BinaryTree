using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree<T> where T : IComparable

    {
        public Node<T> RootNode;

        public void AddNode(T value)
        {
            AddNode(new Node<T>(value), RootNode);
        }

        private void AddNode(Node<T> newNode, Node<T> node)
        {


            if (node == null)
            {
                node = newNode;
            }
            else
            {
                var compare = node.NodeValue.CompareTo(newNode.NodeValue);
                switch (compare)
                {
                    case 1:
                        AddNode(newNode, node.Right);
                        break;
                    case -1:
                        AddNode(newNode, node.Left);
                        break;
                    default: break;
                }
            }

        }
    }
}

