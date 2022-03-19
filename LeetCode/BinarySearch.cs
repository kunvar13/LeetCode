using System;
namespace LeetCode
{
    public class BinarySearch
    {
        public BinarySearch()
        {

        }

        //{ -1, 0, 3, 5, 9, 12 };

        public int BinaryAlgo(int[] nums, int target)
        {
            int mid = (nums.Length / 2);
            int min = 0;
            int max = 0;
            while (true)
            {
                if (mid < target)
                {
                    min = nums[mid];
                    max = nums[nums.Length];
                }

                if(mid > target)
                {
                    min = nums[0];
                    max = nums[mid];

                }
            }


            return 1;
        }
    }
}
