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
           int numLeft = 2;
           int numRight = num/2;
           int numMid;
            long mul;

            if (num < 2)
            {
                return num;
            }

                while (numRight >= numLeft)
                {
                    numMid = numRight - ((numRight - numLeft) / 2);
                    mul = (long)numMid * numMid;

                    if (mul == num)
                    {
                        return numMid;
                    }

                    if (mul > num)
                    {
                        numRight = numMid - 1;
                    }

                    else if (mul < num)
                    {
                        numLeft = numMid + 1;
                    }

                    else
                    {
                        return numRight;
                    }  

                } 

            return numRight;

        }

        public int SearchInsert (int [] nums, int target)
        {
            int right = nums.Length - 1;
            int left = 0;
            int mid;

            while(left <= right)
            {
                mid = left - (left - right) / 2;

                if(nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    left = mid + 1;
                } else
                {
                    right = mid - 1;
                }
            }

            return left;
        }


        public int FindPeakElement(int[] nums)
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (right + left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;

        }
    }

}
