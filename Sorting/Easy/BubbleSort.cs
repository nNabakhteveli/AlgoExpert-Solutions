using System;

public class Program
{
   // Time Complexity: O(n^2) | Space Complexity: O(1)
   public static int[] BubbleSort(int[] array)
   {
      if (array.Length < 2) return array;

      bool isSorted = false;
      while (!isSorted)
      {
         isSorted = true;
         int traverseLen = array.Length;
         for (int i = 0; i < traverseLen; i++)
         {
            if (i < traverseLen - 1 && array[i] > array[i + 1])
            {
               Swap(array, i);
               isSorted = false;
            }
         }
         traverseLen--;
      }
      return array;
   }

   private static void Swap(int[] array, int i)
   {
      int next = array[i + 1];
      array[i + 1] = array[i];
      array[i] = next;
   }
}