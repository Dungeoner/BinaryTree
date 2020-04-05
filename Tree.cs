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
            AddNode( new Node<T>(value),ref RootNode);
        }

        private void AddNode( Node<T> newNode,ref Node<T> node)
        {
            if (node == null)
            {
                node = newNode;
            }
            else
            {
                var compare = newNode.NodeValue.CompareTo(node.NodeValue);
                switch (compare)
                {
                    case 1:
                        AddNode(newNode, ref node.Right);
                        break;
                    case -1:
                        AddNode(newNode, ref node.Left);
                        break;
                    default: break;
                }
            }

        }
    }
}

