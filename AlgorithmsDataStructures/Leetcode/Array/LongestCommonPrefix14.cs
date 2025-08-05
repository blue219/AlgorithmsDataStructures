namespace AlgorithmsDataStructures.Leetcode.Array
{
    internal class LongestCommonPrefix14
    {
        static void Main(string[] args)
        {
            //String[] strs = { "flower", "flow", "flight" };
            String[] strs = { "", "b" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }

        // The array strings all satisfy the same longest common prefix
        static string LongestCommonPrefix(string[] strs)
        {
            // Remember to judge empty
            if (strs == null || strs.Length == 0) return "";

            System.Array.Sort(strs);
            String first = strs[0];
            String last = strs[strs.Length - 1];
            String result = "";
            for (int i = 0; i < first.Length; i++)
            {
                // i < last.Length: Make sure the last index is greater than the first index
                if (i < last.Length && first[i] == last[i])
                {
                    result += first[i];
                }
                else
                {
                    break;
                }
            }
            return result;

        }
    }
}
