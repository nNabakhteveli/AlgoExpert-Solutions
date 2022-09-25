using System;
using System.Collections.Generic;

public static class SmallestDifferencePair
{
   public static int absVal;
   public static int firstNum;
   public static int secondNum;
}

public class Program
{
   public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
   {
      SmallestDifferencePair.absVal = Math.Abs(arrayOne[0] - arrayTwo[0]);
      SmallestDifferencePair.firstNum = arrayOne[0];
      SmallestDifferencePair.secondNum = arrayTwo[0];

      foreach (int i in arrayOne)
      {
         foreach (int j in arrayTwo)
         {
            if (Math.Abs(i - j) < SmallestDifferencePair.absVal)
            {
               SmallestDifferencePair.absVal = Math.Abs(i - j);
               SmallestDifferencePair.firstNum = i;
               SmallestDifferencePair.secondNum = j;
            }
         }
      }
      return new int[] { SmallestDifferencePair.firstNum, SmallestDifferencePair.secondNum };
   }
}