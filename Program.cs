using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name!");
            string Name = Console.ReadLine();
            int stringLength = Name.Length;

            Console.WriteLine($"Your name has {stringLength} letters!");
        }
    }
}
