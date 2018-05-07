using System;
using System.Collections.Generic;

namespace _3.types
{


  interface I1
  {
    void Foo();
  }
  interface I2
  {
    void Foo();
  }

  class Program
  {


    class ImplementTwo : I1, I2
    {
      void I1.Foo()
      {
        Console.WriteLine("Foo of Implement2");
      }

      public void Foo()
      {
        Console.WriteLine("Foo of I2. ");
      }
    }


    public enum BorderSides
    {
      None = 1,
      Left = 2,
      Right = 3,
      Top = 4,
      Bottom = 5
    }


    public class Animal
    {
    }

    public class Bear : Animal
    {

    }

    public class Camel : Animal
    {

    }

    public interface IPoppable<out T>
    {
      T Pop();
    }

    public class Stack<T>
    {
      int position;
      T[] data = new T[100];
      public void Push(T obj) => data[position++] = obj;
      public T Pop()
      => data[--position];
    }


    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");


      var bears = new Stack<Bear>();
      bears.Push(new Bear());
      // Bears implements IPoppable<Bear>. We can convert to IPoppable<Animal>:
      IPoppable<Animal> animals = bears as IPoppable<Animal>;
      // Legal
      Animal a = animals.Pop();

    }

  }
}
