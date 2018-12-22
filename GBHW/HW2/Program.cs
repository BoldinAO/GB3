using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            test.Summ();
            Console.ReadKey();
        }

        struct test
        {
            static int a { get; set; }
            static int summ { get; set; }

            public static void Summ()
            {
                a = 1;
                do
                {
                    Ex();
                } while(a!=0);
                Console.Write("Сумма нечетных чисел = {0}", summ);
            }

            static void Ex()
            {
                try
                {
                    Console.Write("Введите число: ");
                    a = int.Parse(Console.ReadLine());
                    summ = a > 0 ? (a % 2 == 1 ? summ + a : summ) : summ;
                }
                catch
                {
                    Console.WriteLine("Необходимо ввести число!");
                }
            }
        }
    }
}
