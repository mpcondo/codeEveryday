using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 7, 1, 7 };

            Console.WriteLine(Convert.ToString(ContainsDuplicate(nums)));
        }

        static bool ContainsDuplicate(int[] nums)
        {
            bool doesContainDupe = false;
            HashSet<int> hash = new HashSet<int>();

            foreach(var n in nums)
            {
                if (hash.Contains(n)) return doesContainDupe = true;
                else hash.Add(n);
            }

            return doesContainDupe;
        }
    }

    
}

