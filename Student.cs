using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;

        }
        
        public int CompareTo(object obj)
        {
            Student student = (Student) obj;
            if (this.Point > student.Point)
            {
                return 1;
            }

            if (this.Point < student.Point)
            {
                return -1;
            }
            else return 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Point: {Point}";
        }

    }
}
