namespace AlgorithmsDataStructures.LeetCode.Array;

public class TwoSum1
{
    public static void Main(string[] args)
    {
        int[] nums = [3,2,4];
        var target = 6;

        var twoSum1 = new TwoSum1();
        var twoSum = twoSum1.TwoSum(nums, target);
        foreach (var i in twoSum)
        {
            Console.WriteLine(i);
        }
    }

    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }
}