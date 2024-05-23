namespace Solution
{
    class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
          // return true;
          bool isValid = true;
          string[] octets = ipAddres.Split('.');
          // int[] ints = new int[4];
          List<int> ints = new();

          if (octets.Length == 4)
          {
            foreach (string oct in octets)
            {
              ints.Add(int.Parse(oct));
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
