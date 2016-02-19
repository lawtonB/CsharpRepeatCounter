using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace RepeatCount.Objects
{
  public class RepeatCounter
  {

    public static int CountRepeats(string word, string phrase)
    {
      int result = 0;
      string[] phraseArray = phrase.Split(' ');

      for(var i = 0; i < phraseArray.Length; i++)
      {
        if (phraseArray[i] == word)
        {
          result += 1;
        }
      }
      return result;
    }
  }
}
