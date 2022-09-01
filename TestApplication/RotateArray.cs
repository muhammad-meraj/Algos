namespace TestApplication
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int temp;
            k %= nums.Length;
            for (var i = 0; i < k; i++)
            {   
                temp = nums[nums.Length - 1];
                for (var j = nums.Length-2; j >= 0; j--)
                {
                    nums[j + 1] = nums[j];
                }
                nums[0] = temp;
            }
        }

        public void RotateUsingTwoPoint(int[] nums, int k)
        {
            k %= nums.Length;
            var size = nums.Length;
            Reverse(nums, 0, size - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, size - 1);
        }
        
        public void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);
                start++;
                end--;
            }
        }
    }
}