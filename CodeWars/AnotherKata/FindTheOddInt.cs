using System;
namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        Array.Sort(seq);
        ((int[])seq).ToList();
        Console.WriteLine(seq.GetType());
        for (int i=0; i<seq.Length-1; i++)
        {
            if (seq[i] == seq[i+1])
            {
                Console.WriteLine("hi");
                // seq.Slice(0,2);
            } else
            {
                return seq[i];
                // return seq.Slice(seq[1],1);
            }
        }
      return -1;
      }
       
    }
}