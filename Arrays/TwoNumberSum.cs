using System;

public class Program
{
   // Time complexity: O(n ^ 2)
   public static int[] TwoNumberSum(int[] array, int targetSum)
   {
      int[] foundNumbers = new int[2];

      for (int i = 0; i < array.Length; i++)
      {
         for (int j = 0; j < array.Length; j++)
         {
            if (i != j && array[i] + array[j] == targetSum)
            {
               foundNumbers[0] = array[i];
               foundNumbers[1] = array[j];
            }
         }
      }
      return foundNumbers[0] + foundNumbers[1] == targetSum ? foundNumbers : new int[0];
   }
}
