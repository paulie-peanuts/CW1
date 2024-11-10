using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
  public static int[] DeleteNth(int[] arr, int n) {
        // Dictionary to keep track of occurrences of each number
        Dictionary<int, int> counts = new Dictionary<int, int>();
        // List to store the result with limited occurrences
        List<int> result = new List<int>();

        foreach (int number in arr)
        {
            // Get current count or default to 0 if not in dictionary
            int count = counts.ContainsKey(number) ? counts[number] : 0;

            // Add number to result if its count is less than n
            if (count < n)
            {
                result.Add(number);
                counts[number] = count + 1; // Update count in the dictionary
            }
        }

        return result.ToArray();
  }
}

/*
Enough is enough!

Alice and Bob were on a holiday. Both of them took many pictures of the places they've been, and now they want to show Charlie their entire collection. However, Charlie doesn't like these sessions, since the motif usually repeats. He isn't fond of seeing the Eiffel tower 40 times.
He tells them that he will only sit for the session if they show the same motif at most N times. Luckily, Alice and Bob are able to encode the motif as a number. Can you help them to remove numbers such that their list contains each number only up to N times, without changing the order?

Task

Given a list and a number, create a new list that contains each number of list at most N times, without reordering.
For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
With list [20,37,20,21] and number 1, the result would be [20,37,21].