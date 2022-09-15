using System;


public class Program
{
   // Time Complexity: O(n)
   public int FirstNonRepeatingCharacter(string str)
   {
      for (int i = 0; i < str.Length; i++)
      {
         var strWithRemovedChar = str.Remove(i, 1);

         if (strWithRemovedChar.IndexOf(str[i]) == -1)
         {
            return str.IndexOf(str[i]);
         }
      }
      return -1;
   }
}
