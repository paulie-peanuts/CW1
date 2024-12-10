using System;
using System.Text;

public partial class Kata
{
  public static string MakeString(string s)
  {
    string[] words = s.Split(" ");
    StringBuilder answer = new StringBuilder();
    foreach (string word in words)
    {
      answer.Append(word[0]);
    }
    return answer.ToString();     
  }
}

/*
In this exercise, a string is passed to a method and a new string has to be returned with the first character of each word in the string.

For example:

"This Is A Test" ==> "TIAT"
Strings will only contain letters and spaces, with exactly 1 space between words, and no leading/trailing spaces.