using System;

namespace Task1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordCounter wordCounter = new WordCounter();
            string str = Console.ReadLine();
            int count = wordCounter.Count(str);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}

