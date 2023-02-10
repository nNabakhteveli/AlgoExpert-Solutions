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

   public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
   {
      string stringifiedLLOne = ReverseString(LoopThroughLinkedList(linkedListOne));
      string stringifiedLLTwo = ReverseString(LoopThroughLinkedList(linkedListTwo));

      string stringsSum = $"{Int32.Parse(stringifiedLLOne) + Int32.Parse(stringifiedLLTwo)}";

      LinkedList newList = new LinkedList(stringsSum[stringsSum.Length - 1] - '0'); // convert char to int
      LinkedList currLinkedListIterator = newList;

      for (int i = stringsSum.Length - 2; i >= 0; i--)
      {
         currLinkedListIterator.next = new LinkedList(stringsSum[i] - '0'); // convert char to int);
         currLinkedListIterator = currLinkedListIterator.next;
      }
      return newList;
   }

   private string LoopThroughLinkedList(LinkedList linkedList)
   {
      bool shouldStop = false;
      string numsAsStr = "";

      LinkedList curr = linkedList;
      while (shouldStop == false)
      {
         numsAsStr += $"{curr.value}";

         if (curr.next == null) shouldStop = true;
         else curr = curr.next;
      }
      return numsAsStr;
   }

   private string ReverseString(string text)
   {
      string str = "";

      for (int i = text.Length - 1; i >= 0; i--) str += text[i];

      return str;
   }
}