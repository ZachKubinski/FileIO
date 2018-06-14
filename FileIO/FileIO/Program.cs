using System;
using System.Collections;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of Data File: ");
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

            Console.WriteLine("Sum of numbers in data file: " + sum);
            Console.WriteLine("Display the whole list of inputs: ");
            for(int i = 0; i < nums.Count; i++)
            {
                Object o = nums[i];
                Console.Write(o.ToString() + " ");
            }

            Console.WriteLine("Even numbers: ");
            foreach (int i in nums)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Odd numbers: ");
            foreach (int i in nums)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Displays every 5th number
            Console.WriteLine("Every 5th number: ");
            for (int i = 4; i < nums.Count; i += 5)
            {
                int num = Int32.Parse(nums[i].ToString());
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Display numbers divisible by 3: ");
            for(int i = 0; i < nums.Count; i++)
            {
                Object o = nums[i];
                int number = Int32.Parse(o.ToString());
                if(number % 3 == 0)
                {
                    Console.Write(o.ToString() + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
