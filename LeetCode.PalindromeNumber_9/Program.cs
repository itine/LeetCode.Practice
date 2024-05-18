Console.WriteLine(SolutionWithoutAllocation.IsPalindrome(10));

public static class SolutionWithoutAllocation
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        
        if (x / 10 == 0)
            return true;

        int temp = x;
        int y = temp % 10;
        
        while (temp / 10 != 0)
        {
            y = (y * 10) + (temp /= 10) % 10;
        }

        return y == x;
    }
}


public static class SolutionWithStringAllocation
{
    public static bool IsPalindrome(int x)
    {
        string stringNumber = x.ToString();

        for (int i = 0; i < stringNumber.Length / 2; i++)
        {
            if (stringNumber[i] != stringNumber[stringNumber.Length - 1 - i])
                return false;
        }

        return true;
    }
}