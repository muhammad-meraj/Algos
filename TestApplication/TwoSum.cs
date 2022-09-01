using System;
using System.Text;

namespace TestApplication
{
    public class TwoSum
    {
        public int[] Solution(int[] numbers, int target)
        {
            var start = 0;
            var end = numbers.Length - 1;

            while (start < end)
            {
                if(numbers[start] + numbers[end] == target) break;

                if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }

            return new[] {start + 1, end + 1};

        }
        
        
    }
}