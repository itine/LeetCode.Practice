Console.WriteLine(Solution.MyAtoi("   -042"));

public static class Solution
{
    public static int MyAtoi(string input)
    {
        string s = input.Trim();
        if (s.Length == 0)
            return 0;

        int i = 0, sign = 1;
        int? number = null;

        if (s[0] == '-' || s[0] == '+')
        {
            if (s[0] == '-')
                sign *= -1;
            i++;
        }

        for (; i < s.Length; i++)
        {
            if (!char.IsDigit(s[i]))
            {
                break;
            }

            try
            {
                checked
                {
                    int currentDigit = s[i] - '0';
                    number = (number ?? 0) * 10 + currentDigit;
                }
            }
            catch (OverflowException)
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
        }

        return (number ?? 0) * sign;
    }
}