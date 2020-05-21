using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  // Return the missing number!
  public static int FindNumber(int[] array)
  {
    return Enumerable.Range(1, array.Length + 1).Except(array).First();
  }
}