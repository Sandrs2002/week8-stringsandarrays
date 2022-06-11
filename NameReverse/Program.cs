using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            for (int i = Name.Length; i > 0; i--)
            {
                Console.Write(Name[i - 1]);
            }
        }
    }
}
