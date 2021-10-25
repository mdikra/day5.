using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class harmonicnumber
    {
        // C# Program to find sum of series  

        class GFG
        {

            // Function to return sum of 
            // 1/1 + 1/2 + 1/3 + ..+ 1/n 
            static float sum(int n)
            {
                double i, s = 0.0;

                for (i = 1; i <= n; i++)
                    s = s + 1 / i;

                return (float)s;
            }


            // Driven Program 
            public static void Main()
            {
                int n = 5;

                Console.WriteLine("Sum is "
                                   + sum(n));

            }
        }
    }
}
