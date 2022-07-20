using System;
using System.Collections.Generic;

namespace Questions
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      numbers.Add(1);
      numbers.Add(2);
      numbers.Add(3);
      numbers.Add(1);

      foreach (var item in numbers)
      {
        foreach (var itemm in numbers)
        {
          if(item == itemm)
          {
            Console.WriteLine("Duplicate");
          }
          else
          {
            Console.WriteLine("No Duplicate!!!");
          }
        }

      }
      Console.ReadLine();

    }
  }
}
