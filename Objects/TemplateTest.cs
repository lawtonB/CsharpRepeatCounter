using Xunit;
using Anagrams;
using System;
using System.Collections.Generic;
namespace  FindReplaceTest
{
  public class FindReplaceTester
  {
    [Fact]
    public void IsFindReplace_ForWholeWord_true()
    {
      string input1 = "world";
      string input2 = "universe";
      FindReplacer newFindReplacer = new FindReplacer(input1, input2);
      Assert.Equal(input1, newFindReplacer.CompareInputs());
    }
  }
}
