using System;
public class Dinglemouse
{
  public static bool Redacted(string doc1, string doc2)
  {
    if (doc1.Length != doc2.Length)
      return false;

    for (int i = 0; i < doc2.Length; i++)
    {
      if (doc1[i] != doc2[i] && (doc1[i] != 'X' || doc2[i] == '\n'))
      {
        return false;
      }
    }
    return true;
  }
}