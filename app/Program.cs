using System;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    dict.Add(nums[i], 0);
                }
            }
            return false;

            //HashSet ile
            //HashSet<int> set = new HashSet<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (set.Contains(nums[i]))
            //            return true;
            //    set.Add(nums[i]);
            //}
            //return false;

        }
        static void Main(string[] args)
        {
            //[1,2,3,1]
            //[1,2,3,4]
            //[1,1,1,3,3,4,3,2,4,2]

            int[] arr = new int[] { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate(arr));
        }
    }
}
