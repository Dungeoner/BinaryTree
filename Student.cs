using System;

namespace BinaryTree
{
    public class Student : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname.Length <= 15 ? surname : "Surname";
            Age = age;
            Point = point;

        }
        
        public int CompareTo(object obj)
        {
            var student = (Student) obj;
            return this.Point.CompareTo(student.Point) != 0 ? this.Point.CompareTo(student.Point) : this.Surname.CompareTo(student.Surname);
        }
        

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Point: {Point}";
        }

    }
}
