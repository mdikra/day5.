using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class largestamoungthreen
    {
        class Program
        {
            static void Main(string[] args)
            {
                //1
                int first, second, third;

                //2
                Console.WriteLine("Enter the first number : ");
                first = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number : ");
                second = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third number : ");
                third = int.Parse(Console.ReadLine());

                //3
                if (first > second)
                {
                    //4
                    if (first > third)
                    {
                        Console.WriteLine("largest number : " + first);
                    }
                    else
                    {
                        Console.WriteLine("largest number : " + third);
                    }
                }
                else
                {
                    if (second > third)
                    {
                        Console.WriteLine("largest number : " + second);
                    }
                    else
                    {
                        Console.WriteLine("largest number : " + third);
                    }
                }
            }
        }
    }
}