using System;

namespace TestApplication
{
    public class SquareOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            var start = 0;
            var end = nums.Length - 1;
            var result = new int[nums.Length];

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[start]) > Math.Abs(nums[end]))
                {
                    result[i] = nums[start] * nums[start];
                    start++;
                }
                else
                {
                    result[i] = nums[end] * nums[end];
                    end--;
                }
            }
            return result;
        }
    }
}