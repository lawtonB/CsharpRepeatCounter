using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace RepeatCounter.Objects
{
    public class RepeatCounter
  {
      private string _input1;
      private string _input2;
      private string _input3;

    public FindReplacer(string input1, string input2, string input3)
     {
       _input1 = input1;
       _input2 = input2;
       _input3 = input3;
      //  _output.Add(this);
     }

    public string GetInput1()
    {
      return _input1;
    }
    public string GetInput2()
    {
      return _input2;
    }
    public string GetInput3()
    {
      return _input3;
    }

    public string Result()
    {
      // List<string> output = new List<string> {};
      string[] inputToArray = _input1.Split(' ');
      // Console.WriteLine(inputToArray.Length);
      for(var i = 0; i < inputToArray.Length; i++)
      {
        if (inputToArray[i].Contains(_input2))
        {
         inputToArray[i] = inputToArray[i].Replace(_input2, _input3);
        }
      }
      string resultList = string.Join(" ", inputToArray);
      return resultList;
    }
  }
}
