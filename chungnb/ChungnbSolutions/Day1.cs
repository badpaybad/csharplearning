using System;

namespace DayOneNamespace
{
    class DayOne
    {
        public static void Solutions()
        {
            int day = 1;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(1);
            ProblemTwo(1);
            ProblemThree(1);
        }

        private static void ProblemOne(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 1: Input phải >= 1");
                return;
            }

            int sum = (1 + n) * n / 2;
            Console.WriteLine($"Bài số 1: Kết quả là {sum}");
        }

        private static void ProblemTwo(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 2: Input phải >= 1");
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += Math.Pow(i, 2);
            }
            Console.WriteLine($"Bài số 2: Kết quả là {sum}");
        }

        private static void ProblemThree(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 3: Input phải >= 1");
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Bài số 3: Kết quả là {sum}");
        }
    }
}