using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace BasicStringandLINQ
{
    public class Linq1
    {
        public static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

            int result = nums.Min();
            Console.WriteLine("Minimum Value: {0}", result); //Find the min value

            int result2 = nums.Max();
            Console.WriteLine("Maximum Value: {0}", result2); //Find the Max value

            int result3 = nums.Where(x => x < 10000).Max();
            Console.WriteLine("Maximum value less than 10k:{0}", result3); //Find the max value less than 10k

            var result4 = from n in nums
                          where (n > 10 && n < 100)
                          select n;
            foreach (var item in result4)
            {
                Console.WriteLine("The number between 10 and 100 is:" + item);
            }//Find all the values between 10 and 100

            var result5 = from n in nums
                          where (n > 100000 && n < 999999)
                          select n;
            foreach (var item2 in result5)
            {
                Console.WriteLine(" All values between 100k and 999,999 (inclusive):" + item2);
            }//Find all the values between 100k and 999,999 inclusive.


            var result6 = from n in nums
                          where (n % 2 == 0)
                          select n;
            foreach (var item3 in result6)
            {
                Console.WriteLine("All even numbers:" + item3);
            }//Count all the even numbers.
        }
    }
}
