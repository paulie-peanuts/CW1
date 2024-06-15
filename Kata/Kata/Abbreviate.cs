using System;
using System.Text;
namespace Kata;
public class Kata2
{
  public static string AbbrevName(string name)
  {
    StringBuilder abb = new StringBuilder(); 
    string[] words = name.Split(' ');
    foreach (string word in words)
    {
      abb.Append(word[0]);
    }
    abb.ToString().ToCharArray();
    string final = string.Join(".",abb);
    return final;
  }
}