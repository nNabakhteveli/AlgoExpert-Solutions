using System;

public class Program
{
   public class LinkedList
   {
      public int Value;
      public LinkedList Next = null;

      public LinkedList(int value)
      {
         this.Value = value;
      }
   }

   public static void RemoveKthNodeFromEnd(LinkedList head, int k)
   {
      bool shouldStop = false;
      int count = 0;
      LinkedList curr = head;

      while (shouldStop == false)
      {
         if (curr.Next == null) shouldStop = true;

         curr = curr.Next;
         count++;
      }

      curr = head;
      shouldStop = false;

      int removingTarget = count - k;
      count = 0;

      while (shouldStop == false)
      {
         if (removingTarget == 0)
         {
            curr.Value = curr.Next.Value;
            curr.Next = curr.Next.Next;
            break;
         }

         if (count + 1 == removingTarget)
         {
            if (k == 1)
            {
               curr.Next = null;
               break;
            }
            else curr.Next = curr.Next.Next;
         }

         if (curr.Next == null) shouldStop = true;

         count++;
         curr = curr.Next;
      }
   }
}
