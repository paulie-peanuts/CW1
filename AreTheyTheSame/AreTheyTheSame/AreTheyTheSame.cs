using System;
using System.Xml.XPath;
namespace AreTheyTheSame;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if (a == null || b == null)
    {
        return false;
    }
    if (a.Length == 0 && b.Length == 0)
    {
        return true;
    }
    if (a.Length == 0 || b.Length == 0)
    {
        return false;
    }
    Array.Sort(a);
    Array.Sort(b);
    for (int i=0; i<a.Length; i++)
    {
        a[i] = a[i] * a[i];
    }
    for (int i=0; i<a.Length; i++)
    {
        if (a[i] != b[i])
        {
            return false;
        }
    }
    return true;
  }
}