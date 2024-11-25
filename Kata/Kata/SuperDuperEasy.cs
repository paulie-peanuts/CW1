using System;

public class Kata
{
  public static string Problem(String a)
  {
    if (double.TryParse(a, out double value))
      {
        return (value * 50 + 6).ToString();
      }
      else
      {
        return "Error";
      }
  }
}
/*
Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".

Note: in C#, you'll always get the input as a string, so the above applies if the string isn't representing a double value.