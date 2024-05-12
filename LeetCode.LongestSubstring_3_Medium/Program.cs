Console.WriteLine(Solution.LengthOfLongestSubstring("abcabcbb")); //The answer must be "abc", with the length of 3.

public class Solution
{
    private static readonly int S_MAX_LENGTH = 5 * (int)Math.Pow(10, 4);

    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length <= 1)
            return s.Length;
        
        if (s.Length > S_MAX_LENGTH)
            return 0;

        HashSet<char> result = new HashSet<char>();
        int maxLength = 0;
        int leftIndex = 0;
        int rightIndex = 0;

        while (rightIndex < s.Length)
        {
            if (result.Add(s[rightIndex]))
            {
                rightIndex++;
                maxLength = System.Math.Max(maxLength, result.Count);
            }
            else
            {
                result.Remove(s[leftIndex]);
                leftIndex++;
            }
        }

        return maxLength;
    }
}