using System;

namespace DayFiveNamespace
{
    class DayFive
    {
        public static void Solutions()
        {
            int day = 5;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(2, 2);
            ProblemTwo(2, 2);
            ProblemThree(2);
        }

        private static void ProblemOne(int number, int exponent)
        {
            if (exponent <= 0)
            {
                Console.WriteLine($"Bài số 13: Input exponent phải >= 1");
            }

            double rs = 0;
            for (int i = 1; i <= exponent; i++)
            {
                rs += Math.Pow(number, 2 * i);
            }

            Console.WriteLine($"Bài số 13: Kết quả là {rs}");
        }

        private static void ProblemTwo(int number, int exponent)
        {
            if (exponent < 0)
            {
                Console.WriteLine("Bài số 14: Input exponent phải >= 0");
            }

            double rs = 0;
            for (int i = 0; i <= exponent; i++)
            {
                rs += Math.Pow(number, 2 * i + 1);
            }

            Console.WriteLine($"Bài số 14: Kết quả là {rs}");
        }

        private static void ProblemThree(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Bài số 15: Input phải >= 1");
            }

            double rs = 0;
            double denomirator = 0;
            for (int i = 1; i <= n; i++)
            {
                denomirator += i;
                rs += 1.0 / denomirator;
            }

            Console.WriteLine($"Bài số 15: Kết quả là {rs}");
        }
    }
}