using System;
using System.Linq;

public static class Kata
{
  public static string OnesComplement(string n)
  {
    char[] digits = n.ToCharArray();
    for (int i=0; i<digits.Length; i++)
    {
      digits[i] = digits[i] == '0' ? '1' : '0';
    }
    return new string(digits);
  }
}

/*
The Ones' Complement of a binary number is the number obtained by swapping all the 0s for 1s and all the 1s for 0s.

For any given binary number,formatted as a string, return the Ones' Complement of that number.

Examples

"0"    -> "1"
"1"    -> "0"
"000"  -> "111"
"1001" -> "0110"
"1001" -> "0110"