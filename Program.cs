using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_asp_project
{
    

}
    internal class Program
    {
        static void Main(string[] args)

        {

        Console.WriteLine("Enter number of values you want to input:");
        int count = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i< count; ++i)
        {

            Console.WriteLine("enter a value\n");
            string input = Console.ReadLine();
            Object value;
            if (int.TryParse(input, out int intValue))
            {
                value = intValue;
            }
            else if (double.TryParse(input, out double doubleValue))
            {
                value = doubleValue;
            }
            else if (bool.TryParse(input, out bool boolValue))
            {
                value = boolValue;
            }
            else
            {
                value = input; 
            }
            
            Console.WriteLine($"Value: {value}, Type: {value.GetType()}");
        }

    }
     
}

