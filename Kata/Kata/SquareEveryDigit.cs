using System;
using System.Collections.Generic;

public class Kata
{
  public static int SquareDigits(int n)
    {
        List<string> squares = new(); // Store squared digits as strings
        string num = n.ToString(); // Convert number to string
        Console.WriteLine(num); // Print the number string

        // Loop through each character in the string
        for (int i = 0; i < num.Length; i++) 
        {
            int digit = int.Parse(num[i].ToString()); // Convert char to int
            int squared = digit * digit; // Square the digit
            squares.Add(squared.ToString()); // Add squared digit as a string
        }

        string result = string.Join("", squares); // Join all squared digits into one string
        return int.Parse(result); // Convert the result string back to an integer
    }
}
/*
Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)

Note: The function accepts an integer and returns an integer.

Happy Coding!