
using System.Collections;

Solution solution = new Solution();

Console.WriteLine(solution.IsValid("([])"));

public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Any(c => !"(){}[]".Contains(c)))
        {
            return false;
        }
       
        var inputText = "";
        foreach (var c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                inputText += c;
            }
            else
            {
                if (inputText.Length == 0)
                {
                    return false;
                }

                char last = inputText[^1];


                if ((c == ')' && last == '(') ||
                (c == '}' && last == '{') ||
                (c == ']' && last == '['))
                {
                    inputText = inputText.Remove(inputText.Length - 1); 
                }
                else
                {
                    return false;
                }
            }
        }
        return inputText.Length == 0;
    }
}