using System;

public class Program {
	public static bool IsMonotonic(int[] array) {
		if (array.Length <= 1) return true;
        
         int decreasingCount = 0, increasingCount = 0, goal = array.Length - 1;
         for (int i = 0; i < array.Length; i++) {
            if (i > 0 && array[i] <= array[i - 1]) decreasingCount++;
            
            if (i > 0 && array[i] >= array[i - 1]) increasingCount++;
         }

      return decreasingCount == goal || increasingCount == goal ? true : false;
	}
}