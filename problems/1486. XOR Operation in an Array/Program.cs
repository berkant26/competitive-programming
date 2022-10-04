using System;

namespace a
{
    class Program
    {

        static void XORoperation(int n, int start )
        {
            int[] nums = new int[n];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = start + 2 * i;

            }
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {

            XORoperation(5, 0);

        }
    }
}
