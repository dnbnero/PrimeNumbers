using System;
namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ведите последнее число");
            var n_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            int[] numbers = new int[n_n + 1];

            for (int i = 0; i <= n_n; i++)
            {
                numbers[i] = i;
            }

            for (int i = 2; i <= n_n; i++)
            {
                for (int b = 2; b <= n_n; b++)
                {
                    if (i * b <= n_n)
                    {
                        numbers[b * i] = 0;
                    }
                }
            }

            for (int i = 0; i <= n_n; i++)
            {
                if (numbers[i] == 0 ^ numbers[i] == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            while (true) ;
        }
    }
}