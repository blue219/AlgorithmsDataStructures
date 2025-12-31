namespace AlgorithmsDataStructures.LeetCode.Array;

public class RemoveElement27
{
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                count++;
                nums[count - 1] = nums[i];
            }
        }
        
        return count;
    }
}