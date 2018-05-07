using System;
using System.Collections.Generic;

namespace _4.advanced
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");


        foreach(var i in EvenNumbers(Fibonacci(20))) {
            Console.WriteLine(i);
        }

    }


    public static IEnumerable<int> Fibonacci(int length)
    {
      for (int i = 0, prevFib = 1, curFib = 1; i < length; i++)
      {
        yield return prevFib;
        int newFib = curFib + prevFib;
        prevFib = curFib;
        curFib = newFib;
      }
    }

    public static IEnumerable<int> EvenNumbers (IEnumerable<int> numbers) {
        foreach(int i in numbers) {
            if (i % 2 == 0) {
                yield return i;
            }
        }
    }
  }
}
