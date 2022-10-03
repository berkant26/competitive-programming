using System;

namespace Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    class Program
    {


        static void Main(string[] args)
        {
            int reminder, sum = 0;
            int product = 1;
            int num = 768;

            while (num != 0)
            {
                reminder = num % 10;
                sum += reminder;
                product *= reminder;
                num /= 10;

            }


            Console.WriteLine($"product of digits of given number is : {product}.  sum of digits of given number is {sum}" );
        }
    }
}
