using System;

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
