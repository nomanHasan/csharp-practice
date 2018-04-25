using System;

namespace _2.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char c = 'A';

            Console.WriteLine(c);
            Console.WriteLine(isEven(23));
            Console.WriteLine(divide(y:100, x:25 ));
        }

        static Func<int, bool> isEven = x => x % 2 == 0; 

        static float divide (int x, int y ) {
            Console.WriteLine(x + " - and y is " + y);
            return (float)x / (float)y;
        }
    }
}
