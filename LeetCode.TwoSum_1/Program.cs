using System.Collections.Generic;

internal class Program
{
    private static class Solution
    {
        public static int[] TwoSum(int[]? nums, int target)
        {
            if (nums is null || nums.Length == 0)
                return new[] { 0, 0 };
            Dictionary<int, int> map = new();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int operandForSum = target - nums[i];
                if (map.TryGetValue(operandForSum, out int value))
                {
                    return new[] { value, i };
                }

                map[nums[i]] = i;
            }

            return new[] { 0, 0 };
        }
    }

    public static void Main(string[] args)
    {
        int[] res = Solution.TwoSum(new[] { 3, 2, 3 }, 6);
    }
}