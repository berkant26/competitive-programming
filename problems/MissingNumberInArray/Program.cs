using System;

namespace Competetive
{
    class Program
    {


        static void missingNUmberInArray(int[] nums)
        {

            int temp = 0;


            for(int i = 0; i <nums.Length; i++)
            {
                for (int j = 0; j <nums.Length; j++)
                {
                    if(nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }                                                            
                }               
            }


            int x = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != x)
                {
                    Console.WriteLine("missing number is : "+x);
                }
                x++;
            }




            


        }

        static void Main(string[] args)
        {

            missingNUmberInArray(new int[] { 1, 2, 4, 5, 6, 3, 8 });


        }
    }
}
