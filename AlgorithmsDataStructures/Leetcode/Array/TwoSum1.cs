using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Leetcode.Array
{
    internal class TwoSum1
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            TwoSum(nums, target);

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        Console.WriteLine(i+j);
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
    }
}
