using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  // Return the missing number!
  public static int FindNumber(int[] array)
  {
    if (array.Length < 1)
    {
      return 1;
    }
    else
    {
      var missing = Enumerable.Range(1, array.Max()).Except(array);
      return missing.Any() ? missing.First() : array.Max() + 1;
    }
  }
}