static int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (i == j)
                continue;

            var sum = nums[j] + nums[i];
            if (sum == target)
                return new int[] { i, j };

        }
    }
    return default;
}

static void WriteSum(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
        Console.WriteLine(nums[i]);

}

var sum = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
WriteSum(sum);
var sum2 = TwoSum(new int[] { 3, 2, 4 }, 6);

WriteSum(sum2);
var sum3 = TwoSum(new int[] { 3, 3 }, 6);

WriteSum(sum3);