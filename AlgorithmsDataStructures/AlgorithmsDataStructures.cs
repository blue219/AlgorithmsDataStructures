using AlgorithmsDataStructures.LeetCode.Array;

namespace AlgorithmsDataStructures;

public static class AlgorithmsDataStructures
{
    public static void Main(string[] args)
    {
        /*int[] nums = [3,2,2,3];
        int val = 3;*/

        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        int val = 2;

        var removeElement27 = new RemoveElement27();
        var removeElement = removeElement27.RemoveElement(nums, val);
        Console.WriteLine(removeElement);

        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
    }
}