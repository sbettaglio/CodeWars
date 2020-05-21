using System;
using System.Linq;
public class Number
{
  public int DigitalRoot(long n)
  {
    var numString = n.ToString();
    var root = 0;
    while (numString.Length > 1)
    {
      for (var i = 0; i < numString.Length; i++)
      {
        var converter = Char.ToString(numString[i]);
        root = root + int.Parse(converter);
      }
      numString = root.ToString();
      root = 0;
    }
    return numString.Length == 0 ? 0 : Convert.ToInt32(numString);
  }
}