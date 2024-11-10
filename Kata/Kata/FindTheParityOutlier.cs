using System;
using System.Linq;

public class Kata
{
    public static int Find(int[] integers)
    {
        // Check the first three elements to determine the array's general parity
        bool isMostlyEven = integers.Take(3).Count(n => n % 2 == 0) > 1;

        // Find and return the outlier based on the array's general parity
        return integers.First(n => (n % 2 == 0) != isMostlyEven);
    }
}

/*
You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.

Examples

[2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)
*/