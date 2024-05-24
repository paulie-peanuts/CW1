// using NUnit.Framework;
// using System;
// using System.Collections.Generic;
using System.Text;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    char[] letters = str.ToCharArray();
    StringBuilder answer = new();
        for (int i=0; i < letters.Length; i++)
        {
            if (!caps.Contains(letters[i]))
            {
                answer.Append(letters[i]);
            } else
            {
                answer.Append(' ');
                answer.Append(letters[i]);
            }
        }
        return answer.ToString();
  }
}
/*
Complete the solution so that the function will break up camel casing, using a space between words.

Example

"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/