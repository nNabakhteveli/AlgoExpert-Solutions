using System;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		// Write your code here.
		int[] foundNumbers = new int[2];
        int[] emptyArr = {};

        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < array.Length; j++) {
                if (i != j && array[i] + array[j] == targetSum) {
                    foundNumbers[0] = array[i];
                    foundNumbers[1] = array[j];
                }
            }
        }
        return foundNumbers[0] + foundNumbers[1] == targetSum ? foundNumbers : emptyArr;
	}
}
