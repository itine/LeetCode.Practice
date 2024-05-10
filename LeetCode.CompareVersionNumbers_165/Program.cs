class Program
{
    /// <summary>
    /// Compare with comparator
    /// </summary>
    /// <param name="version1">String with version 1</param>
    /// <param name="version2">String with version 2</param>
    /// <returns></returns>
    public static int CompareVersionWithComparator(string version1, string version2)
    {
        return Compare(version1.Split('.'), version2.Split('.'));
        
        int Compare(string[] left, string[] right) =>
            (left, right) switch 
            {
                ({ Length: 0 },{ Length: 0 }) => 0,
                ({ Length: 0 }, _) => int.Parse(right[0]) != 0 ? -1 : Compare(Array.Empty<string>(), right[1..]),
                (_,{ Length: 0 }) => int.Parse(left[0]) != 0 ? 1 : Compare(left[1..], Array.Empty<string>()),
                _ => int.Parse(left[0]) == int.Parse(right[0])
                    ? Compare(left[1..], right[1..])
                    : int.Parse(left[0]) < int.Parse(right[0]) ? -1 : 1
            };
    }
    
    /// <summary>
    /// My solution
    /// </summary>
    /// <param name="version1">String with version 1</param>
    /// <param name="version2">String with version 2</param>
    /// <returns></returns>
    public static int CompareVersion(string version1, string version2)
    {
        if (string.IsNullOrEmpty(version1) || string.IsNullOrEmpty(version2))
            return 0;

        string[] digitsV1 = version1.Split('.');
        string[] digitsV2 = version2.Split('.');

        int maxLength = Math.Max(digitsV1.Length, digitsV2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            int digitV1 = 0;
            int digitV2 = 0;

            if (i < digitsV1.Length)
            {
                int.TryParse(digitsV1[i], out digitV1);
            }

            if (i < digitsV2.Length)
            {
                int.TryParse(digitsV2[i], out digitV2);
            }

            if (digitV1 < digitV2)
                return -1;
            
            if (digitV1 > digitV2) 
                return 1;
        }

        return 0;
    }
    

    static void Main(string[] args)
    {
        Console.WriteLine(CompareVersionWithComparator("1.01", "1.001"));
    }
}