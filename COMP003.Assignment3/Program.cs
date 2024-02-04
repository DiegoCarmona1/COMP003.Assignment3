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
            Console.WriteLine("Input Day of week: (1-7)");
            string inputDay = Console.ReadLine();
            int numericDay = Convert.ToInt32(inputDay);
            switch (numericDay)
            {
                case 1:
                    Console.WriteLine("String Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("String Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("String Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("String Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("Strinmg Day: Sunday");
                    break;
                default: Console.WriteLine("Invalid Day");
                    break;
            }
        }
    }
}
