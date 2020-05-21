using System;
using System.Linq;
public class Number
{
  public int DigitalRoot(long n)
  {
    while (n > 9)
    {
      n = n.ToString().Select(c => Convert.ToInt32(c.ToString())).Sum();
    }
    return (int)n;
  }
}