using System;
namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ведите последнее число");
            var n_n = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(" ");
            ulong[] numbers = new ulong[n_n + 1];

            for (ulong i = 0; i <= n_n; i++)
            {
                numbers[i] = i;
            }

            for (ulong i = 2; i <= n_n; i++)
            {
                for (ulong b = 2; b <= n_n; b++)
                {
                    if (i * b <= n_n)
                    {
                        numbers[b * i] = 0;
                    }
                }
            }

            for (ulong i = 0; i <= n_n; i++)
            {
                if (numbers[i] == 0 ^ numbers[i] == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}