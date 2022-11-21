using System;

public class Program {
   // Time Complexity: O(n), Space Complexity: O(1)
	public static bool IsMonotonic(int[] array) {
		if (array.Length <= 1) return true;
        
         int decreasingCount = 0, increasingCount = 0, streak = array.Length - 1;
         for (int i = 0; i < array.Length; i++) {
            if (i > 0 && array[i] <= array[i - 1]) decreasingCount++;
            
            if (i > 0 && array[i] >= array[i - 1]) increasingCount++;
         }

      return decreasingCount == streak || increasingCount == streak ? true : false;
	}
}