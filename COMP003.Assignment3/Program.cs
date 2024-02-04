using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Diego Carmona
 * Course: COMP003A 
 * Purpose: To further mastery over conditional statements
 */

namespace COMP003.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-else section
            Console.WriteLine("Input integer between 1-100");
            string inputNumber = Console.ReadLine();
            double numericGrade = Convert.ToDouble(inputNumber);
            if (numericGrade <= 90) { Console.WriteLine("Letter Grade: A"); }
            else if (numericGrade >= 80) { Console.WriteLine("Letter Grade: B"); }
            else if (numericGrade >= 70) { Console.WriteLine("Letter Grade: C"); }
            else if (numericGrade >= 60) { Console.WriteLine("Letter Grade: D"); }
            else { Console.WriteLine("Letter Grade: F"); } 
            if (numericGrade == double.NaN) { Console.WriteLine("Invalid Input"); }
            
            //Switch Section

        }
    }
}
