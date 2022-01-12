using System;
using System.Collections.Generic;
using System.Text;

namespace Day6LogicalProblem
{
    public class ReverseNum
    {
        public void ReverseTheNum()
        {
            int num, reverse = 0, rem;
            Console.WriteLine("Enter the num ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reverse the number " + reverse);
        }

    }
}
