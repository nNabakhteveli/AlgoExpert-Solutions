using System;
using System.Collections.Generic;

/*
  Write a function that takes in a non-empty array of distinct integers and an
  integer representing a target sum. The function should find all triplets in
  the array that sum up to the target sum and return a two-dimensional array of
  all these triplets. The numbers in each triplet should be ordered in ascending
  order, and the triplets themselves should be ordered in ascending order with
  respect to the numbers they hold.
  If no three numbers sum up to the target sum, the function should return an
  empty array.
*/
public class Program
{
   public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
   {
      if (array.Length < 3) return new List<int[]>();

      var list = new List<int[]>();
      for (int i = 0; i < array.Length; i++)
      {
         for (int j = 0; j < array.Length; j++)
         {
            for (int k = 0; k < array.Length; k++)
            {
               if (
                   i != j && k != j && k != i &&
                   array[i] + array[j] + array[k] == targetSum
               )
               {
                  int[] arrToAdd = { array[i], array[j], array[k] };
                  if (IsUnique(arrToAdd, list) == true)
                  {
                     list.Add(InsertionSort(arrToAdd));
                     break;
                  }
               }
            }
         }
      }
      return InsertionSort(list);
   }

   public static bool IsUnique(int[] first, List<int[]> second)
   {
      foreach (var i in second)
      {
         int equalsCount = 0;
         for (int j = 0; j < i.Length; j++)
         {
            if (Array.IndexOf(i, first[j]) != -1)
            {
               equalsCount++;
            }
         }
         if (equalsCount == 3) return false;
      }
      return true;
   }

   // Override with different param
   public static List<int[]> InsertionSort(List<int[]> list)
   {
      for (int i = 1; i <= list.Count - 1; i++)
      {
         var currNum = list[i];
         var prevNumIdx = i - 1;

         while (
             prevNumIdx >= 0 && (currNum[0] < list[prevNumIdx][0] ||
             currNum[0] == list[prevNumIdx][0] && currNum[1] < list[prevNumIdx][1] ||
             currNum[0] == list[prevNumIdx][0] && currNum[1] == list[prevNumIdx][1] && currNum[2] < list[prevNumIdx][2]
             )
         )
         {
            list[i] = list[prevNumIdx];
            list[prevNumIdx] = currNum;
            i -= 2;
         }
      }
      return list;
   }

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