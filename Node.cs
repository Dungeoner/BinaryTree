using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T> where T : IComparable
    {
        public Node(T value)
        {
            NodeValue = value;
        }
        public T NodeValue { get; private  set; }
        public Node<T> Right;
        public Node<T> Left;




    }
}
