using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace FindReplace.Objects
{
    public class FindReplacer
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

    public string Result()
    {
      List<string> output = new List<string> {};
      string[] inputToArray = _input1.Split();
      Console.WriteLine(inputToArray.Length);
      for(var i = 0; i < inputToArray.Length; i++)
      {
        if (inputToArray[i].Contains(_input2))
        {
          return inputToArray[i] = inputToArray[i].Replace(_input2, _input3);
        }
        else{}
      }
      return "try again";
    }
  }
}

      // public void SetVariable(string newVariable)
      // {
      //   _TEMPLATEVARIABLE = newVariable;
      // }
      // public void Replace(string[] output, string input2, string input3)
