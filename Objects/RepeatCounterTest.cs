using Xunit;
using RepeatCounter.Objects;
using System;
using System.Collections.Generic;
namespace  RepeatCounterTest
{
  public class RepeatCounterTester
  {
    [Fact]
    public void IsRepeatCounter_ForSingleWord_true()
    {
      string input1 = "cat";
      string input2 = "cat";
      RepeatCounter newRepeatCounter = new RepeatCounter(input1, input2);
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void IsRepeatCounter_ForSingleWord_false()
    {
      string input1 = "cat";
      string input2 = "dog";
      RepeatCounter newRepeatCounter = new RepeatCounter(input1, input2);
      Assert.Equal(0, newRepeatCounter.CountRepeats());
    }
  }
}

//     // public void IsFindReplace_ForWholeAllWordsInSentence_true()
//     // {
//     //   string input1 = "world hello world";
//     //   string input2 = "world";
//     //   string input3 = "universe";
//     //   FindReplacer newFindReplacer = new FindReplacer(input1, input2, input3);
//     //   Assert.Equal(input3, newFindReplacer.Result());
//     // }
//   }
// }
