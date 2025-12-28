namespace AlgorithmsDataStructures.LeetCode.Array;

public class LongestCommonPrefix14
{
    public string LongestCommonPrefix(string[] strs)
    {
        string common = "";

        for (int i = 0; i < strs[0].Length; i++)
        {
            string temp = strs[i].Substring(0, i + 1);
            foreach (var str in strs)
            {
                if (!str.StartsWith(temp))
                {
                    return common;
                }
            }

            common = temp;
        }

        return common;
    }
}