using System.Collections.Generic;
using System;


public class Program
{
   // This is an input class. Do not edit.
   public class LinkedList
   {
      public int value;
      public LinkedList next;

      public LinkedList(int value)
      {
         this.value = value;
         this.next = null;
      }
   }

   // Time Complextity: O(n*m), where n is length of linkedListOne and m is length of linkedListTwo | Space Complexity: O(n)
   public LinkedList MergingLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
   {
      bool shouldStop = false;
      LinkedList currLLOne = linkedListOne;
      LinkedList currLLTwo = linkedListTwo;

      while (shouldStop == false)
      {
         bool nestedShouldStop = false;
         LinkedList nestedCurrLLTwo = linkedListTwo;

         while (nestedShouldStop == false)
         {
            if (currLLOne.value == nestedCurrLLTwo.value) return currLLOne;
            else if (nestedCurrLLTwo.next != null) nestedCurrLLTwo = nestedCurrLLTwo.next;
            else nestedShouldStop = true;
         }

         currLLOne = currLLOne.next;
         currLLTwo = currLLTwo.next;

         if (currLLOne == null || currLLTwo == null) shouldStop = true;
      }
      return null;
   }
}