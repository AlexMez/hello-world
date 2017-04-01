using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInputtedNum
{
    class Program

    //Author: Alex Meza
    // This program reverses a number
    {

        static void Main(string[] args)
        {

            // put in infinate loop to try multiple numbers.

            while (0 < 10)
            {

                // prompts user to input a number

                Console.WriteLine("Enter a whole number");

                string input = Console.ReadLine();

                //convert string input into a number that can be %, /, etc..

                Int64 g = Convert.ToInt64(input);



                //  reverses the number, use % 10 to get the last number then move it left by multipling by 10

                Int64 reversedNum = 0;
                while (g != 0)
                {
                    reversedNum = reversedNum * 10 + g % 10;
                    g = g / 10;
                }

                //print reverted number

                Console.WriteLine(reversedNum);







            }
        }
    }
}

