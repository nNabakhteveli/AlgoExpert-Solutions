using System;
using System.Collections.Generic;

public class Program
{
   // For every method: Time Complexity: O(1) | Space Complexity: O(1)
   public class MinMaxStack
   {
      public List<int> stack = new List<int>();
      public List<int> minNums = new List<int>();
      public List<int> maxNums = new List<int>();

      public int Peek() => stack.Count == 0 ? -1 : stack[stack.Count - 1];

      public int Pop()
      {
         int poppedValue = stack[stack.Count - 1];

         stack.RemoveAt(stack.Count - 1);

         if (minNums.Count > 0 && poppedValue == minNums[minNums.Count - 1])
         {
            minNums.RemoveAt(minNums.Count - 1);
         }

         if (maxNums.Count > 0 && poppedValue == maxNums[maxNums.Count - 1])
         {
            maxNums.RemoveAt(maxNums.Count - 1);
         }

         return poppedValue;
      }

      public void Push(int number)
      {
         if (maxNums.Count == 0 || number >= maxNums[maxNums.Count - 1])
         {
            maxNums.Add(number);
         }

         if (minNums.Count == 0 || number <= minNums[minNums.Count - 1])
         {
            minNums.Add(number);
         }

         stack.Add(number);
      }

      public int GetMin() => minNums[minNums.Count - 1];

      public int GetMax() => maxNums[maxNums.Count - 1];
   }
}