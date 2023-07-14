using System;
using System.Collections.Generic;

public class Program
{
   // Time Complexity: O(n^2) | Space Complexity: O(1)
   public static List<int> MoveElementToEnd(List<int> array, int toMove)
   {
      for (int i = 1; i < array.Count; i++)
      {
         if (array[i] != toMove)
         {
            while (i > 0 && array[i - 1] == toMove)
            {
               array[i - 1] = array[i];
               array[i] = toMove;
               i--;
            }
         }
      }
      return array;
   }
}
