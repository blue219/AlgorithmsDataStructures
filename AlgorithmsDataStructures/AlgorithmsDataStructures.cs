using AlgorithmsDataStructures.LeetCode.Array;

namespace AlgorithmsDataStructures;

public static class AlgorithmsDataStructures
{
    public static void Main(string[] args)
    {
        string[] strs = ["a"];

        var longestCommonPrefix14 = new LongestCommonPrefix14();
        Console.WriteLine(longestCommonPrefix14.LongestCommonPrefix(strs));
    }
}