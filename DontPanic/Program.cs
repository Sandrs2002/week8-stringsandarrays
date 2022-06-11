using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string calm = "K33p C4lm";

            calm = calm.Replace('3', 'e');
            calm = calm.Replace('4', 'a');

            Console.WriteLine(calm);
        }
    }
}
