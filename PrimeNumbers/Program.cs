using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("Ведите последнее число");
            var n_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            int[] numbers = new int[n_n + 1];

            //stopWatch.Start();

            for (int i = 0; i <= n_n; i++)
            {
                numbers[i] = i;
            }

            //stopWatch.Stop();

            for (int i = 0; i <= n_n; i++)
            {

            }

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine(stopWatch.Elapsed);

            while (true) ;
        }
    }
}