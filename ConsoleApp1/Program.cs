using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            var result = ProductOfArray(nums);
            Console.WriteLine(result);
        }

        static string ProductOfArray(int[] nums)
        {
            string answer = "[ ";
            for (int n = 0; n < nums.Length; n++)
            {
                int multiplier = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[n] != nums[i])
                    {
                        multiplier = multiplier * nums[i];
                    }
                }
                answer = answer + Convert.ToString(multiplier) + ", ";
            }
            return answer + "]";
        }
    }
}
