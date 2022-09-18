using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace problem
{
    class Program
    {

        public static void sortAnArray(int[] nums)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }







        static void Main(string[] args)
        {

            sortAnArray(new int[] { 2, 3, 1, 5, 4 });




        }

    }

}

