using System.Diagnostics.CodeAnalysis;

namespace TestApplication
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target) {
            var start = 0;
            var end = nums.Length;
            int midPoint;

            if (target > nums[^1]) return nums.Length;

            while (start <= end)
            {
                midPoint = start + (end - start) / 2;
                if (nums[midPoint] == target) return midPoint;
                if (nums[midPoint] < target) start = midPoint + 1;
                if (nums[midPoint] > target) end = midPoint - 1;
            }

            return start;
        }
    }
}