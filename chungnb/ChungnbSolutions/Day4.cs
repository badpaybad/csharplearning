using System;

namespace DayFourNamespace
{
    class DayFour
    {
        public static void Solutions()
        {
            int day = 4;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(2, 3);
            ProblemTwo(4);
            ProblemThree(2, 3);
        }

        private static void ProblemOne(int n, int x)
        {
            double rs = Math.Pow(n, x);
            Console.WriteLine($"Bài số 10: Kết quả là {rs}");
        }

        private static void ProblemTwo(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 11: Input phải >= 1");
                return;
            }
            
            int rs = 0;
            int tempRs = 1;
            for (int i = 1; i <= n; i++)
            {
                tempRs *= i;
                rs += tempRs;
            }

            Console.WriteLine($"Bài số 11: Kết quả là {rs}");
        }

        private static void ProblemThree(int number, int exponent)
        {
            if (exponent <= 0) {
                Console.WriteLine("Bài số 12: Input exponent phải >= 1");
                return;
            }

            double rs = 0;
            for (int i = 1; i <= exponent; i++)
            {
                rs += Math.Pow(number, i);
            }

            Console.WriteLine($"Bài số 12: Kết quả là {rs}");
        }
    }
}