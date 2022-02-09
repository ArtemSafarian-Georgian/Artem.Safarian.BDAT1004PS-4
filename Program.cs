using System;
using System.Collections.Generic;

namespace Question_4
{


    class Program
    {

        static void Main(string[] args)
        {


            int[] data = { 25, 47, 42, 56, 32 };
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();



            int i = 0;
            foreach (var numbers in data)
            {

                if (numbers % 2 != 0)
                {
                    oddNumbers.Add(numbers);
                }
                else
                {
                    evenNumbers.Add(numbers);

                }
                i++;
            }

            int[] oddArray = oddNumbers.ToArray();
            int[] evenArray = evenNumbers.ToArray();


            Console.WriteLine("The even elements are:");
            foreach (var evenNumber in evenArray)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("The Odd elements are:");
            foreach (var oddNumber in oddArray)
            {
                Console.WriteLine(oddNumber);
            }


        }
    }
}
