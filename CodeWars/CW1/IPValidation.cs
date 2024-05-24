// using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Solution
{
    class Kata
    {
        public static bool IsValidIp(string ipAddres)
        {
          bool isValid = true;
          string[] octets = ipAddres.Split('.');
          List<int> ints = new();
          int num;

          if (octets.Length == 4)
          {
            foreach (string oct in octets)
            {
              if (oct.Length == 0 || (oct[0] == '0' && oct.Length != 1) || oct[0] == '-' || oct.Trim() != oct)
              {
                return false;
              }
            }
            foreach (string oct in octets)
            {
              if (int.TryParse(oct, out num))
              {
                ints.Add(int.Parse(oct));
              } else
              {
                return false;
              }
            }
            foreach (int inte in ints)
            {
              if (inte > 255)
              {
                isValid = false;
              }
            }
            return isValid;
          }
          
          return false;
          
        }
    }
}