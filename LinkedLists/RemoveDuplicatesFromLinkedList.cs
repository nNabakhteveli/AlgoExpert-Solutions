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

   public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
   {
      bool didEnded = false;
      var currList = linkedList;

      while (!didEnded)
      {
         if (currList == null || currList.next == null)
         {
            didEnded = true;
            break;
         }

         if (currList.value == currList.next.value)
         {
            var findNonDuplicate = FindNonDuplicateNode(currList.value, currList.next);

            if (findNonDuplicate.value != currList.value)
            {
               currList.next = findNonDuplicate;
            }
            else
            {
               currList.next = null;
            }
         }
         currList = currList.next; // change iteration object
      }
      return linkedList;
   }

   public LinkedList FindNonDuplicateNode(int currNum, LinkedList nextNode)
   {
      var currList = nextNode;

      while (currNum == currList.value && currList.next != null) currList = currList.next;

      return currList;
   }
}