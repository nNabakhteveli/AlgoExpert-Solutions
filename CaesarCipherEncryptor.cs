using System;
using System.Collections.Generic;

public class Program
{
   // Time Complexity: O(n)
   public static string CaesarCypherEncryptor(string str, int key)
   {
      char[] alphabetArr = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
      int alphabetLen = alphabetArr.Length;
      string modifiedStr = "";

      for (int i = 0; i < str.Length; i++)
      {
         int indexOfCurrentCharInAlphabet = Array.IndexOf(alphabetArr, str[i]);

         if (indexOfCurrentCharInAlphabet + key <= alphabetLen - 1)
         {
            modifiedStr += alphabetArr[indexOfCurrentCharInAlphabet + key];
         }
         else
         {
            modifiedStr += alphabetArr[(key + indexOfCurrentCharInAlphabet) % alphabetLen];
         }
      }
      return modifiedStr;
   }
}