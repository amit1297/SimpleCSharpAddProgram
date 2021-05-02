using System;

namespace SimpleCSharpAddProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int a  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("=================================");
            Console.WriteLine("Your result is " + c);
            Console.WriteLine("=================================");
            Console.ReadLine();
        }
    }
}
