using System;

namespace QuickSort_Inplace
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 9, 4, 7, 5, 8, 6, 1, 3, 2 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach(var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;
            var pivotIndex = (left + right) / 2;
            var pivotValue = arr[pivotIndex];
            Swap(arr, pivotIndex, right);
            var swapIndex = left;
            for (var i = left; i < right; i++)
            {
                if (arr[i] <= pivotValue)
                {
                    Swap(arr, swapIndex, i);
                    swapIndex++;
                }
            }
            Swap(arr, swapIndex, right);
            QuickSort(arr, left, swapIndex - 1);
            QuickSort(arr, swapIndex + 1, right);
        }

        public static void Swap(int[] arr, int x, int y)
        {
            var temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
