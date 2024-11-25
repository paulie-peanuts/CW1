using System;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int total = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] > 0)
      {
        total += arr[i];
      }
    }
    return total;
  }
}
/*
You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.