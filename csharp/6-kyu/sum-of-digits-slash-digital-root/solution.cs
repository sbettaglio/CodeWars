using System;
using System.Linq;
public class Number
{
  public int DigitalRoot(long n)
  {
    var numString = n.ToString();
    var root = 0;
    for (var i = 0; i < numString.Length; i++)
    {
      var converter = Char.ToString(numString[i]);
      root = root + int.Parse(converter);
    }
    while (root > 9 && root > 0)
    {
      root = 0;
      var reducer = root.ToString();
      for (var j = 0; j < reducer.Length; j++)
      {
        var looper = Char.ToString(reducer[j]);
        root = root + int.Parse(looper);
      }
    }
    return root;
  }
}