
using System;

namespace LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}

// Short Hand if else

using System;

namespace LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            string result = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)
                ? $"{year} is a leap year."
                : $"{year} is not a leap year.";

            Console.WriteLine(result);
        }
    }
}
