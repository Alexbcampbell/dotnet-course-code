﻿
using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] intsToCompress = new int[] {10,15,20,25,30,12,34};

             DateTime startTime = DateTime.Now;

            int totalValue = intsToCompress[0] + intsToCompress[1] + intsToCompress[2] +
            intsToCompress[3] + intsToCompress[4] + intsToCompress[5] + intsToCompress[6];

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            //146

            totalValue = 0;

            startTime = DateTime.Now;

            for (int i = 0; i < intsToCompress.Length; i++)
            {
                totalValue += intsToCompress[i];
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

             totalValue = 0;

            startTime = DateTime.Now;

            foreach(int intForCompression in intsToCompress)
            {
                totalValue += intForCompression;
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            totalValue = 0;

            int index = 0;

            while(index < intsToCompress.Length)
            {
                totalValue += intsToCompress[index];
                index++;
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            totalValue = 0;

            index = 0;

            do
            {
                totalValue += intsToCompress[index];
                // Console.WriteLine(index);
                // Console.WriteLine(index < intsToCompress.Length);
                index++;
            }
            while(index < intsToCompress.Length);
            //Console.WriteLine(index);

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            startTime = DateTime.Now;
            totalValue = 0;
            totalValue = intsToCompress.Sum();

             Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


        }
    }
}