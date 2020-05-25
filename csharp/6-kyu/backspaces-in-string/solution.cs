using System;
using System.Text;

public class Kata
{
  public static string CleanString(string s)
  {
    var answer = new StringBuilder(s.Length);
    for (var i = 0; i < s.Length; i++)
    {
      if (!s[i].Equals('#'))
      {
        answer.Append(s[i]);
      }
      else if (s[i].Equals('#') && s.Length > 0)
      {
        if (answer.Length > 0)
          answer.Remove(answer.Length - 1, 1);
      }
    }
    return answer.ToString();
  }
}