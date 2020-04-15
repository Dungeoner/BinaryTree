using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var oak = new Tree<Student>();
            oak.AddNode(new Student("A", "A", 24, 2));
            oak.AddNode(new Student("B", "B", 22, 4));
            oak.AddNode(new Student("C", "C", 24, 1));
            oak.AddNode(new Student("D", "E", 24, 6));
            oak.AddNode(new Student("E", "D", 24, 6));
            oak.AddNode(new Student("F", "F", 24, 55));
            oak.AddNode(new Student("G", "G", 24, 7));
            oak.AddNode(new Student("H", "H", 24, 9));
            oak.AddNode(new Student("I", "I", 24, 11));
            oak.AddNode(new Student("J", "J", 24, 88));
            var print = new TreePrint<Student>();
            print.Print(oak);
            
            var intTree = new Tree<int>();
            for (var i = 0; i < 6; i++)
            {
                int[] array = {10, 5, 20, 25, 3, 7,};
                var rndValue = array[i];
                Console.WriteLine(rndValue);
                intTree.AddNode(rndValue);
                
            }
            var intPrint = new TreePrint<int>();
            intPrint.Print(intTree);
            Console.ReadKey();
        }
    }
}
