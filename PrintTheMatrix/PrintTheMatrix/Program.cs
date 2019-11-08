using System;

namespace PrintTheMatrix
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] intArr = {1, 2, 3, 4, 5};

      for (int i = intArr.Length-1; i >= 0; i--)
      {
        Console.WriteLine("");
        for (int j = 1; j <= intArr.Length; j++)
        {
          if (j <= intArr[i])
          {
            Console.Write(i+1);
          } else 
            Console.Write(j);
        }
        
      }
    }                                                                                                                                                                                                   

  }
}
