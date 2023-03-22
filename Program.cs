// See https://aka.ms/new-console-template for more inf
using System;
namespace Conditional
{
    class IfStatement
    {
        public static void Main(string[] args)
        {
            int value = 3;
            if (value < 10)
            {
                Console.WriteLine("{0} is less than 10", value);
            }
            Console.WriteLine("this statement is always executed");

        }
    }
}