using System;
using System.Linq;
public class Kata
{
  public static int WhoDominates(int[] array)
  {
    Array.Sort(array);
    var value = 0;
    var count = 0;
    for (var i = 0; i < array.Length; i++)
    {
      if (value == array[i])
      {
        count++;
      }
      else
      {
        value = array[i];
        count = 1;
      }
      if (count > array.Length / 2)
      {
        return value;
      }
    }
    return -1;
  }
}