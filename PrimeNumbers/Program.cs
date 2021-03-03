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

            stopWatch.Start();

            for (int i = 0; i <= n_n; i++)
            {
                numbers[i] = i;
            }

            stopWatch.Stop();

            //for (int i = 0; i <= n_n; i++)
            //{
            //    for (int b = 0; b <= n_n; b++)
            //    {
            //        if (numbers[b] == 0 ^ numbers[i] == 0 ^ numbers[b] == 1 ^ numbers[i] == 1)
            //        {
            //            continue;
            //        }
            //
            //    }
            //}

            for (int i=0;i<=n_n;i++)
            {
                if (numbers[i] == 0 ^ numbers[i] == 1)
                {
                        continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stopWatch.Elapsed);

            while (true) ;
        }
    }
}