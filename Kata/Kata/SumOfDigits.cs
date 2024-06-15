using System;
namespace Kata
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            if (n <= 9 && n>= 0)
            {
                return (int)n;
            } else
            {
                string a = n.ToString();
                a.Split();
                Console.WriteLine(a);
                return -1;
            }
            return -1;

    
        }
    }
    public class Convert
    {

    }
}
