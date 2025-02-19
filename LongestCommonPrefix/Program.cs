

Solution solution = new Solution();
Console.WriteLine(solution.LongestCommonPrefix(["a"]));
Console.WriteLine(solution.LongestCommonPrefix(["flower", "flow", "flight"]));
Console.WriteLine(solution.LongestCommonPrefix(["dog", "racecar", "car"]));
Console.WriteLine(solution.LongestCommonPrefix(["ab", "a"]));
Console.WriteLine(solution.LongestCommonPrefix([""]));


public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }

        if (!(strs.Length >= 1 && strs.Length <= 200))
        {
            return string.Empty;
        }
        Array.Sort(strs);
        var prefix = string.Empty;
        for (int i = 0; i < strs[0].Length; i++)
        {
            prefix += strs[0][i];

            var isPrefix = strs.All(x => x.StartsWith(prefix));

            if (!isPrefix)
                return prefix.Substring(0, prefix.Length - 1);
        }
        return prefix;
    }
}

