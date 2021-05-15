using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 1, 3, 5, 7, 9 };
            int[] arrayB = new int[] { 2, 4, 6, 8, 10 };
            int[] sortedArray = MergeSortedArrays(arrayA, arrayB);

            Console.WriteLine(" -= Merged Arrays Solution =- ");
            Console.WriteLine();
            Console.Write(string.Join(", ", sortedArray));
            Console.ReadKey();
        }

        public static int[] MergeSortedArrays(int[] arrayA, int[] arrayB)
        {
            if (arrayA == null || arrayA.Length == 0) return new int[] { };
            if (arrayB == null || arrayB.Length == 0) return new int[] { };

            int[] sortedArray = new int[arrayA.Length + arrayB.Length];

            int i = 0, j = 0, k = 0;

            while (i < arrayA.Length && j < arrayB.Length)
                sortedArray[k++] = arrayA[i] < arrayB[j] ? arrayA[i++] : arrayB[j++];

            while (i < arrayA.Length)
                sortedArray[k++] = arrayA[i++];

            while (j < arrayB.Length)
                sortedArray[k++] = arrayB[j++];

            return sortedArray;
        }
    }
}