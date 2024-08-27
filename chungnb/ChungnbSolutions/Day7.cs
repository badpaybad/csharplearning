using System;
using SupportNamespace;

namespace DaySevenNamespace
{
    class DaySeven
    {
        public static void Solutions()
        {
            int day = 7;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(1, 1);
            ProblemTwo(10);
            ProblemThree(10);
        }

        private static void ProblemOne(int n, int x)
        {
            double rs = 1;
            for (int i = 0; i <= n; i++)
            {
                double numerator   = Math.Pow(x, 2 * i + 1);
                double denominator = Support.factorialCal(2 * i + 1);
                rs += numerator / denominator;
            }

            Console.WriteLine($"Bài số 19: Kết quả là {rs}");
        }

        private static void ProblemTwo(int n)
        {
            // tìm danh sách ước
            if (n <= 0)
            {
                Console.WriteLine("Bài số 20: Input n phải >= 1");
                return;
            }

            int middleNumber = (int)Math.Floor(n / 2.0);
            int[] rs         = new int[0];
            for (int i = 1; i <= middleNumber; i++)
            {
                if (n % i == 0)
                {
                    Array.Resize(ref rs, rs.Length + 1);
                    rs[rs.Length - 1] = i;
                }
            }

            string displayRs = String.Join(", ", rs);
            Console.WriteLine($"Bài số 20: Kết quả là [{displayRs}]");
        }

        private static void ProblemThree(int n)
        {
            // tính tổng ước
            if (n <= 0)
            {
                Console.WriteLine("Bài số 20: Input n phải >= 1");
                return;
            }

            int middleNumber = (int)Math.Floor(n / 2.0);
            int[] rs = new int[0];
            for (int i = 1; i <= middleNumber; i++)
            {
                if (n % i == 0)
                {
                    Array.Resize(ref rs, rs.Length + 1);
                    rs[rs.Length - 1] = i;
                }
            }

            int sum = 0;
            int numberRs = rs.Length;
            for (int i = 0; i < numberRs; i++)
            {
                sum += rs[i];
            }

            Console.WriteLine($"Bài số 21: Kết quả là {sum}");
        }
    }
}