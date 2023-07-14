using System;

public class Program
{
   public static int[] InsertionSort(int[] array)
   {
      for (int i = 1; i <= array.Length - 1; i++)
      {
         int currNum = array[i];
         int prevNumIdx = i - 1;

         while (prevNumIdx >= 0 && currNum < array[prevNumIdx])
         {
            array[i] = array[prevNumIdx];
            array[prevNumIdx] = currNum;
            i -= 2;
         }
      }
      return array;
   }
}