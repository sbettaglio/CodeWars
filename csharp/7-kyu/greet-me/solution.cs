using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return $"Hello {name[0].ToString().ToUpper() + name.ToLower().Substring(1)}!";
  }
}