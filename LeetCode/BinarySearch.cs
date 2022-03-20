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
            int mid;
            int min = 0;
            int max = nums.Length - 1;
            while (min <= max)
            {
                mid = max - ((max-min) / 2);

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target) //
                {
                    min = mid + 1;
                } else
                {
                    max = mid - 1;
                }
            }


            return -1;
        }

        public int Sqrt(int num)
        {
            int numLeft = 0;
            int numRight = num;
            int numMid;

            while (numRight >= numLeft)
            {
                numMid = numRight - ((numRight - numLeft) / 2);
                
                if ((numMid * numMid) == num)
                {
                    return numMid;
                }

                if (numMid * numMid > num)
                {
                    numRight = numMid - 1;
                }

                else
                {
                    numLeft = numMid + 1;
                }

            }

            return -1;

        }
        
    }
}
