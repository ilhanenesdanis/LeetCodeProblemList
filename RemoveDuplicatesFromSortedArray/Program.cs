
Solution Solution = new Solution();

Console.WriteLine(Solution.RemoveDuplicates([1, 1, 2]));
Console.WriteLine(Solution.RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));




public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int i = 0; 

        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            { 
                i++; 
                nums[i] = nums[j];
            }
        }

        return i + 1;
    }
}


