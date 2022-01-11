using System;
using System.Collections.Generic;
using System.Text;

namespace Day6LogicalProblem
{
    class FirstQue
    {
        public void FabonacciSeries()
        {
            int a, b,number,i,c;
            a = 0;
            b = 1;
            Console.WriteLine("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
