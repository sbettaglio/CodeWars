namespace Age
{
  using System;

  public class Kata
  {
    public static string HowOld(DateTime birthday)
    {
      var yearAge = DateTime.Today.Year - birthday.Year;
      var monthAge = DateTime.Today.Month - birthday.Month;
      var days = (DateTime.Today.Day - birthday.Day);
      if (days < 0)
      {
        monthAge -= 1;
        days += 30;
      }
      if (monthAge < 0)
      {
        monthAge += 12;
        yearAge -= 1;
      }
      return ($"Peter is {yearAge} years, {monthAge} months and {days} days old");
    }
  }
}