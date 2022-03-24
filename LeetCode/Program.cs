using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new BinarySearch();
            int[] nums = { 1, 3, 5, 6 };
            //Console.WriteLine(result.BinaryAlgo(nums,10));
            //int Sqrt = 2;
            Console.WriteLine (result.FindPeakElement(nums));
        }
    }
}
