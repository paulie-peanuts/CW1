using System;

public class Kata
{
  public static string GetMiddle(string s)
  {
    return s.Length % 2 == 0 ? s.Substring(s.Length/2 - 1, 2) : s.Substring((s.Length-1)/2, 1);
  }
}

/*
You are going to be given a non-empty string. Your job is to return the middle character(s) of the string.

If the string's length is odd, return the middle character.
If the string's length is even, return the middle 2 characters.
Examples:

"test" --> "es"
"testing" --> "t"
"middle" --> "dd"
"A" --> "A")