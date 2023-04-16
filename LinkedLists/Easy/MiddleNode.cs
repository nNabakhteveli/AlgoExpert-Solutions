using System.Collections.Generic;
using System;


public class Program {
	// This is an input class. Do not edit.
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

	public LinkedList MiddleNode(LinkedList linkedList) {
		// Write your code here.
		var copy = linkedList;
        var count = 1;
        
        while (copy.next != null) {
            count++;
            copy = copy.next;
        }

        copy = linkedList;
        var secondCount = 0;
        
        while (copy.next != null) {
            secondCount++;

            if ((count / 2) + 1 == secondCount) return copy;
        
            copy = copy.next;
        }
        
        return copy;
	}
}
