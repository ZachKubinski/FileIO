﻿using System;
using System.Collections;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Directory to Data File: ");
            String fileName = Console.ReadLine();
            ArrayList nums = new ArrayList();
            Int32 sum = 0;


            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Int32 curNum = Int32.Parse(line);
                        nums.Add(curNum);
                        sum += curNum;
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            //Finds the sum of the numbers
            Console.WriteLine("Sum of numbers in data file: \n" + "[" + sum + "]");
            Console.WriteLine("Display the whole list of inputs: ");
            Console.Write("[");
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(nums[i]);
                }
                else
                {
                    Console.Write(", " + nums[i]);
                }
            }
            //Finds all the even numbers
            Console.WriteLine("]");
            Console.WriteLine("Even numbers: ");
            Console.Write("[");
            ArrayList ar = new ArrayList();
            foreach (int i in nums)

            {

                if (i % 2 == 0)

                {

                    ar.Add(i);

                }

            }
            //Writes to console all the even numbers
            for (int i = 0; i < ar.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(ar[i]);
                }
                else
                {
                    Console.Write(", " + ar[i]);
                }
            }
            Console.WriteLine("]");
            ar.Clear();
            //Finds all odd numbers
            Console.WriteLine("Odd numbers: ");
            Console.Write("[");
            foreach (int i in nums)

            {

                if (i % 2 != 0)

                {

                    ar.Add(i);

                }

            }
            //Writes to console all odd numbers
            for (int i = 0; i < ar.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(ar[i]);
                }
                else
                {
                    Console.Write(", " + ar[i]);
                }
            }
            Console.WriteLine("]");
            ar.Clear();
            // Finds every 5th number
            Console.WriteLine("Every 5th number: ");
            Console.Write("[");
            for (int i = 4; i < nums.Count; i += 5)
            {
                int num = Int32.Parse(nums[i].ToString());
                ar.Add(num);
            }
            //Writes to console every 5th number
            for (int i = 0; i < ar.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(ar[i]);
                }
                else
                {
                    Console.Write(", " + ar[i]);
                }
            }
            Console.WriteLine("]");
            ar.Clear();
            //Finds every number divisible by 3
            Console.WriteLine("Display numbers divisible by 3: ");
            Console.Write("[");
            for (int i = 0; i < nums.Count; i++)
            {
                Object o = nums[i];
                int number = Int32.Parse(o.ToString());
                if (number % 3 == 0)
                {
                    ar.Add(o.ToString() + " ");
                }
            }
            //Writes to console all numbers divisible by 3
            for (int i = 0; i < ar.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(ar[i]);
                }
                else
                {
                    Console.Write(", " + ar[i]);
                }
            }
            Console.WriteLine("]");
            ar.Clear();
            Console.ReadKey();
        }
    }
}
