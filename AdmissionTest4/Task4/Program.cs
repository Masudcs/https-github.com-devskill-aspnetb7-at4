// See https://aka.ms/new-console-template for more information
using System;

namespace Task4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormatChecker format = new FormatChecker();
            string str = Console.ReadLine();
            bool count = format.IsValid(str);

            //if (count)
            //{
            //    Console.WriteLine("True");
            //}
            //else {
            //    Console.WriteLine("False");
            //}
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
