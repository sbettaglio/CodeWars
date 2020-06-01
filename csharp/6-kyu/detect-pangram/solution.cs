using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    return str.Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() >= 26;
  }
}