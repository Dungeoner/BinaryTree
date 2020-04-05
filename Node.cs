using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<T> where T : IComparable
    {
        public Node(T value)
        {
            NodeValue = value;
        }
        public T NodeValue { get; set; }
        public Node<T> Right;
        public Node<T> Left;




    }
}
