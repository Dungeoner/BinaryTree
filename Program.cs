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
            Oak.AddNode(new Student("B", "B", 22, 4));
            Oak.AddNode(new Student("C", "C", 24, 1));
            Oak.AddNode(new Student("D", "E", 24, 6));
            Oak.AddNode(new Student("E", "D", 24, 6));
            Oak.AddNode(new Student("F", "F", 24, 55));
            Oak.AddNode(new Student("G", "G", 24, 7));
            Oak.AddNode(new Student("H", "H", 24, 9));
            Oak.AddNode(new Student("I", "I", 24, 11));
            Oak.AddNode(new Student("J", "J", 24, 88));
            var print = new TreePrint<Student>();
            print.Print(Oak);
            
            Tree<int> IntTree = new Tree<int>();
            for (int i = 0; i < 6; i++)
            {
                int[] array = {10, 5, 20, 25, 3, 7,};
                int rndValue = array[i];
                Console.WriteLine(rndValue);
                IntTree.AddNode(rndValue);
                
            }
            var intPrint = new TreePrint<int>();
            intPrint.Print(IntTree);
            Console.ReadKey();
        }
    }
}
