using System;
using System.Diagnostics;
using System.Threading;
namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём таймер
            Stopwatch stopWatch = new Stopwatch();

            //Спрашиваем у пользователя число N
            Console.WriteLine("Ведите последнее число");
            var n_n = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(" ");

            //Запускаем таймер
            stopWatch.Start();

            //Создаем массив чисел от 0 до N
            ulong[] numbers = new ulong[n_n + 1];
            for (ulong i = 0; i <= n_n; i++)
            {
                numbers[i] = i;
            }

            //Заменяем не простые числа на ноль
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

            //Выводим простые числа от 2 до N
            for (ulong i = 0; i <= n_n; i++)
            {
                if (numbers[i] == 0 ^ numbers[i] == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            //Останавливаем таймер и выводим результат
            stopWatch.Stop();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(stopWatch.Elapsed);

            Console.ReadKey();
        }
    }
}