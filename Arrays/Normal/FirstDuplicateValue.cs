using System.Collections.Generic;
using System;


public class Program
{
   // Time Complexity: O(n) | Space Complexity: O(1)
   // Solution without any other DS
   public int FirstDuplicateValue(int[] array)
   {
      int lowestIdxOfDuplicates = -1;

      for (int i = 0; i < array.Length; i++)
      {
         int currItem = array[i];
         array[i] = int.MinValue; // replace current element with something else, to find its duplicate's index

         int idxOfDuplicate = Array.IndexOf(array, currItem);
         if (idxOfDuplicate != -1 && idxOfDuplicate > i && (idxOfDuplicate < lowestIdxOfDuplicates || lowestIdxOfDuplicates == -1))
         {
            lowestIdxOfDuplicates = idxOfDuplicate;
         }
         array[i] = currItem;
      }
      return lowestIdxOfDuplicates == -1 ? -1 : array[lowestIdxOfDuplicates];
   }

   // Time Complexity: O(n) | Space Complexity: O(n)
   // Another solution with List
   public int FirstDuplicateValue(int[] array)
   {
      var items = new List<int>();

      foreach (var i in array)
      {
         if (items.IndexOf(i) != -1)
         {
            return i;
         }
         items.Add(i);
      }
      return -1;
   }
}