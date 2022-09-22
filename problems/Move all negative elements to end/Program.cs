using System;

namespace Subarray_with_given_sum
{
    class Program
    {



       private static void moveAllNegative(int[] nums)
        {

            

            int temp = 0; 
            for(int i = 0;  i < nums.Length -1 ; i++)
            {
                if(nums[i] > nums[ i + 1])
                {
                    temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                }


            }

            int temp2 = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = nums.Length -1; j > 3; j--)
                {
                    if(nums[i] < nums[j])
                    {
                        temp2 = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp2;

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


            moveAllNegative(new int[] { -2, 0, -1, 2, 3, 4 });




        }
    }
}
