using System;


namespace Question_1
{
    public class Program
    {
        public static int[] SwapIndices(int[] arr, int first, int second)
        {
            if (first >= arr.Length || second >= arr.Length || first < 0 || second < 0) return arr;

            int[] mod = (int[])arr.Clone();
            int temp = mod[first];
            mod[first] = mod[second];
            mod[second] = temp;

            return mod;
        }
        public static void display(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            // TESTING MY FUNCTION
            int[] testArr = { 34, 45, 87, 90, 76, 12, 29, 10, 33, 18 };
            int[] swapped = SwapIndices(testArr, 5, 9);
            display(swapped);
        }
    }
}
