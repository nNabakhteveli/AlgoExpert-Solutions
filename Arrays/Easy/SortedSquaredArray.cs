using System;

public class Program
{

   public int[] SortedSquaredArray(int[] array)
   {
      var squaredNums = new int[array.Length];

      for (int i = 0; i < array.Length; i++)
      {
         squaredNums[i] = array[i] * array[i];
      }

      for (int i = 0; i < squaredNums.Length; i++)
      {
         int currentItem = squaredNums[i];
         while (i > 0 && currentItem < squaredNums[i - 1])
         {
            int prevItemIndex = i - 1;
            squaredNums[i] = squaredNums[prevItemIndex];
            squaredNums[prevItemIndex] = currentItem;
            i = prevItemIndex;
         }
      }
      return squaredNums;
   }
}