
Solution solution = new Solution();

Console.WriteLine(solution.StrStr("sadbutsad", "sad"));
Console.WriteLine(solution.StrStr("leetcode", "leeto"));


public class Solution
{
    public int StrStr(string haystack, string needle)
    {

        if(needle.Length == 0)
        {
            return 0;
        }

        if (haystack.Length < needle.Length)
        {
            return -1;
        }

      

        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
        }

        return -1;
    }
}