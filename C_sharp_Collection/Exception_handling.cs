using System;

namespace C_sharp
{
    internal class Exception_handling
    {
        public static void Main(String[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter the first number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;

                Console.WriteLine(c);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't be divided by zero");
            }

        }
    }
}