using System;

class Program
{
    public static void QuickSort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    private static void Sort(int[] array, int low, int high)
    {
        if (low >= high) return;

        int pivot = array[low];
        int left = low + 1;
        int right = high;

        while (right >= left)
        {
            if (array[left] > pivot && array[right] < pivot)
            {
                SwapElements(array, left, right);
                left += 1;
                right -= 1;
            }
            else if (array[left] <= pivot) left += 1;
            else if (array[right] >= pivot) right -= 1;
        }

        SwapElements(array, low, right);

        bool leftSubArrayIsSmaller = right - 1 - low < high - (right + 1);

        if (leftSubArrayIsSmaller)
        {
            Sort(array, low, right - 1);
            Sort(array, right + 1, high);
        }
        else
        {
            Sort(array, right + 1, high);
            Sort(array, low, right - 1);
        }
    }

    private static void SwapElements(int[] array, int indexOne, int indexTwo)
    {
        int temp = array[indexOne];
        array[indexOne] = array[indexTwo];
        array[indexTwo] = temp;
    }
}
