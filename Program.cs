using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<Student> Oak = new Tree<Student>();
            Oak.AddNode(new Student("A", "A", 24, 2));
            Oak.AddNode(new Student("B", "A", 22, 4));
            Oak.AddNode(new Student("C", "A", 24, 1));
            Oak.AddNode(new Student("D", "A", 24, 6));
            Oak.AddNode(new Student("E", "A", 24, 34));
            Oak.AddNode(new Student("F", "A", 24, 55));
            Oak.AddNode(new Student("G", "A", 24, 7));
            Oak.AddNode(new Student("H", "A", 24, 9));
            Oak.AddNode(new Student("I", "A", 24, 11));
            Oak.AddNode(new Student("J", "A", 24, 88));
            var print = new TreePrint<Student>();
            print.Print(Oak);
            Console.ReadKey();
        }
    }
}
