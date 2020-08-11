using System;
using System.Linq;
using System.Collections.Generic;
public class Kata

{

  public static (int, int)[] TwosDifference(int[] array)
  {
    return array.Where(i => array.Contains(i + 2)).Select(i => (i, i + 2)).OrderBy(i => i).ToArray();
  }
}