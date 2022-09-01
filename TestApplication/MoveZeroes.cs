using System;

namespace TestApplication
{
    public class MoveZeroes
    
    {
        public void Solution(int[] nums)
        {

            var i = 0;
            while(i < nums.Length)
            {
                if (nums[i] == 0)
                {
                    Reverse(nums, i, nums.Length - 1 - i);
                    Reverse(nums, i, nums.Length - 2 - i);
                }
                i++;
            }

            foreach (var num in nums)
            {
                Console.Write($" {num}");
            }
        }

        void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);
                ++start;
                --end;
            }
        }

        public void Solution2(int[] nums)
        {
            var a = 0;
            var b = 1;

            while (a < nums.Length && a < b && b < nums.Length)
            {
                if (nums[a] == 0 && nums[b] != 0)
                {
                    (nums[a], nums[b]) = (nums[b], nums[a]);
                    a++;
                    b++;
                } else if (nums[a] == 0 && nums[b] == 0)
                {
                    b++;
                }
                else
                {
                    a++;
                    b++;
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine($" {num}");
            }

            ;
        }
    }
}