using System;

public class Program
{
   public static bool IsPalindrome(string str)
   {
      if (str.Length == 1) return true;

      string reversedStr = "";
      for (int i = str.Length - 1; i >= 0; i--)
      {
         reversedStr += str[i];
      }
      return str == reversedStr;
   }
}
