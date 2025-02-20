





Solution solution = new Solution();

int[] nums = [3, 2, 2, 3];

Console.WriteLine(solution.RemoveElement(nums, 3));
Console.WriteLine(solution.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2));



public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;

        var currentNums = nums.ToList();

        currentNums.RemoveAll(x => x == val);

        currentNums.CopyTo(nums);

        return currentNums.Count;
    }
}