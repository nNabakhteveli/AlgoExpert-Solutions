using System;

public class Program {
	public int[] ArrayOfProducts(int[] array) {
        var arr = new int[array.Length];

        for (int i = 0; i < array.Length; i++) {
            int multiplication = 1;
            for (int j = 0; j < array.Length; j++) {
                if (j != i) {
                    multiplication *= array[j];
                }
            }    
            arr[i] = multiplication;
        }
		return arr;
	}
}
