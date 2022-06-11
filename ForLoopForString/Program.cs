using System;

namespace ForLoopForString
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";

            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello[2]);
            //Console.WriteLine(hello[3]);
            //Console.WriteLine(hello[4]);

            for(int i = 0; i < hello.Length; i++)
            {
                Console.WriteLine(hello[i]);
            }

            Console.WriteLine( );

            for(int i = hello.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(hello[i]);
            }
        }
    }
}
