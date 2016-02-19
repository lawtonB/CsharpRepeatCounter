using Xunit;
using RepeatCount.Objects;
using System;
using System.Collections.Generic;
namespace RepeatCounterTest
{
  public class RepeatCounterTester
  {
    [Fact]
    public void DoesRepeatCounter_ForSingleWord_Equal1()
    {
      string testWord = "cat";
      string testPhrase = "cat";
      Assert.Equal(1, RepeatCounter.CountRepeats(testWord, testPhrase));
    }
    [Fact]
    public void DoesRepeatCounter_ForSingleWord_Equal0()
    {
      string testWord = "cat";
      string testPhrase = "dog";
      Assert.Equal(0, RepeatCounter.CountRepeats(testWord, testPhrase));
    }
  }
}
