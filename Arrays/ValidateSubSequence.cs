using System;
using System.Collections.Generic;

public class Program
{
   // Solution 1:
   // Time Complexity: O(n), where n is the length of the array
   public static bool IsValidSubsequence1(List<int> array, List<int> sequence)
   {
      int matchCount = 0;
      for (int i = 0; i < array.Count; i++)
      {
         if (matchCount <= sequence.Count - 1 && sequence[matchCount] == array[i])
         {
            matchCount++;
         }
      }
      return matchCount == sequence.Count;
   }

   // Solution 2:
   // Time Complexity: O(n^2)
   public static bool IsValidSubsequence2(List<int> array, List<int> sequence)
   {
      var newArr = new List<int>();

      // Filter out non-neccessary elements from array
      foreach (int i in array)
      {
         if (sequence.Contains(i) && newArr.Count < sequence.Count)
         {
            newArr.Add(i);
         }
      }

      if (newArr.Count != sequence.Count)
      {
         return false;
      }

      for (int i = 0; i < newArr.Count; i++)
      {
         if (newArr[i] != sequence[i])
         {
            return false;
         }
      }
      return true;
   }
}
