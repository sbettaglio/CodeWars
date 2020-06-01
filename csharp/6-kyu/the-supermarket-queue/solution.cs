using System;
using System.Collections;
using System.Linq;
public class Kata
{
  public static long QueueTime(int[] customers, int n)
  {
    int[] checkout = new int[n];

    for (int i = 0; i < customers.Length; i++)
    {
      checkout[Array.IndexOf(checkout, checkout.Min())] += customers[i];
    }
    return checkout.Max();
  }
}