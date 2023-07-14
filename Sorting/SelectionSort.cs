using System;

public class Program
{
   // Time Complexity: O(n^2), where n is length of the array | Space Complexity: O(1)
   public static int[] SelectionSort(int[] array)
   {
      for (int a = 0; a < array.Length; a++)
      {
         int smallestNum = array[a];
         int smallestNumIdx = a;
         for (int b = 0 + a; b < array.Length; b++)
         {
            if (array[b] < smallestNum)
            {
               smallestNum = array[b];
               smallestNumIdx = b;
            }
         }
         array[smallestNumIdx] = array[a];
         array[a] = smallestNum;
      }
      return array;
   }
}
