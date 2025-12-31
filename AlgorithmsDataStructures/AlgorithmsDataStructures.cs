using AlgorithmsDataStructures.LeetCode.Array;

namespace AlgorithmsDataStructures;

public static class AlgorithmsDataStructures
{
    public static void Main(string[] args)
    {
        int[] nums = [0,0,1,1,1,2,2,3,3,4];

        var removeDuplicatesfromSortedArray26 = new RemoveDuplicatesfromSortedArray26();
        var removeDuplicates = removeDuplicatesfromSortedArray26.RemoveDuplicates(nums);
        Console.WriteLine(removeDuplicates);

        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
    }
}