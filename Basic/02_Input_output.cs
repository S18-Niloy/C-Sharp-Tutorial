using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();  // Read input as a string
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
