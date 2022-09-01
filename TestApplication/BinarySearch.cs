using System;

namespace TestApplication
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            // int[] arr = new int[]{-1, 0, 3, 5, 9, 12};
            // int target = 9;
            var start = 0;
            var end = nums.Length - 1;
            int midPoint;

            while (start <= end)
            {
                //midPoint = (end + start) / 2;
                midPoint = start + ((end - start) / 2);

                if (nums[midPoint] == target)
                {
                    Console.WriteLine($"Found target, midpoint = {midPoint}");
                    return midPoint;
                }

                if (nums[midPoint] < target)
                {
                    Console.WriteLine($"Target = {target} is greater than midPoint = {nums[midPoint]}, new start = {midPoint}");
                    start = midPoint + 1;
                }

                if (nums[midPoint] > target)
                {
                    Console.WriteLine($"Target = {target} is smaller than midPoint = {midPoint}, new end = {midPoint}");
                    end = midPoint - 1;
                }
            }

            return -1;
        }
    }
}