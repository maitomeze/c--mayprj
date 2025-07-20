using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_asp_project
{
    public class Student
    {
        public string name;
        public int grades;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> x = new List<Student>();
            Student[] students = new Student[3];
            for (int i = 0; i < 3; ++i)
            {
                students[i] = new Student();
                Console.WriteLine("enter your name\n");
                students[i].name = Console.ReadLine();
                Console.WriteLine("enter your grade\n");
                students[i].grades = Convert.ToInt32(Console.ReadLine());
                if (students[i].grades > 70)
                {
                    x.Add(students[i]);
                   
                }
            }
            foreach (Student s in x)
            {
                Console.WriteLine($"Name: {s.name}, Grade: {s.grades}");
                Console.WriteLine("\n");
            }
           

        }
    }
}
