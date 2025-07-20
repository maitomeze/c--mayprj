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
        public List<int> grades = new List<int>();
        public double avggrage()
        {
            double avr;
            if (grades == null )
                return 0;
            return grades.Average();
        }
       

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
                Console.WriteLine("Enter number of grades:");
                int numGrades = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < numGrades; j++)
                {
                    Console.WriteLine("Enter grade");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    students[i].grades.Add(grade);
                }
                double avg = students[i].avggrage();

                if (avg > 70)
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
