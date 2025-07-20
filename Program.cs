using first_asp_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_asp_project
{
    public class Employee
    {
        public string name;
        public int salary;

    }
    class Manager: Employee
    {
        public string Department;
    }
}
    internal class Program
    {
        static void Main(string[] args)

        {
        Employee emp = new Employee();
        Manager man = new Manager();
        man.salary = 2000;
        man.name = "mahmoud";
        man.Department = "engieer";
        Console.WriteLine(" Manager Data :\n");
        Console.WriteLine("name :"+ man.name);
        Console.WriteLine("\n");
        Console.WriteLine("salary :"+ man.salary);
        Console.WriteLine("\n");
        Console.WriteLine("Manager : "+ man.Department);
        Console.WriteLine("\n");

    }
     
}

