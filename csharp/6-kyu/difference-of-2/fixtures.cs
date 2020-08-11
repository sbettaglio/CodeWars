namespace Solution {
  using NUnit.Framework;

  [TestFixture]
  public class SampleTests
  {
    [Test]
    public void Tests()
    {
      Assert.AreEqual(new (int, int)[]{(1, 3), (2, 4)}, Kata.TwosDifference(new int[]{1, 2, 3, 4}));
      Assert.AreEqual(new (int, int)[]{(1, 3), (4, 6)}, Kata.TwosDifference(new int[]{1, 3, 4, 6}));
    }
  }
}