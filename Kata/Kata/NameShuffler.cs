using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    string[] parts = str.Split(" ");
    
    return $"{parts[1]} {parts[0]}";
  }
}

/*
DESCRIPTION:

Write a function that returns a string in which firstname is swapped with last name.

Example(Input --> Output)

"john McClane" --> "McClane john"