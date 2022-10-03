using System;

namespace NumberOfGoodPairs
{
    class Program
    {

        private static void NumberOfGoodPairs(int[] nums)
        {
            int c = 1;
            int Count = 0;
            for(int i = 0; i < nums.Length; i++)
            {
               for(int j = c ; j <nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        Count++;
                    }
                    
                }
                c++;

            }
            Console.WriteLine(Count);

        }
        static void Main(string[] args)
        {

            NumberOfGoodPairs(new int[] { 1,1,1,1 });
        }
    }
}
