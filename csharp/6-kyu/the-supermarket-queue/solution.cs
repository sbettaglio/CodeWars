using System;
using System.Collections;
using System.Linq;
public class Kata
{
  public static long QueueTime(int[] customers, int n)
  {

    if (n <= 1)
    {
      return customers.Sum();
    }
    else if (customers.Max() < n)
    {
      return customers.Max();
    }
    else
    {
      Queue line = new Queue();
      for (var i = 0; i < customers.Length; i++)
      {
        line.Enqueue(customers[i]);
      }
      while (line.Count > 0)
      {

      }
      return (line);
    }
  }
}