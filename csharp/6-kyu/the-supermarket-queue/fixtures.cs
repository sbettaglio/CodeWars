namespace Solution
{
  using NUnit.Framework;

  using System;

  [TestFixture]
  public class Tests
  {
    [Test]
    public void ExampleTest1()
    {
      long expected = 0;

      long actual = Kata.QueueTime(new int[] { }, 1);

      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
      long expected = 10;

      long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
      long expected = 9;

      long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest4()
    {
      long expected = 12;

      long actual = Kata.QueueTime(new int[] { 2, 3, 10 }, 2);

      Assert.AreEqual(expected, actual);
    }
  }
}