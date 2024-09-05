using System;
using SupportNamespace;

namespace DayNineSolutions
{
    class DayNine
    {
        public static void Solutions()
        {
            int day = 9;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(10);
            ProblemTwo(10);
            ProblemThree(10);
        }

        private static void ProblemOne(int n)
        {
            // tính tích ước
            if (n <= 0)
            {
                Console.WriteLine("Bài số 22: Input n phải >= 1");
                return;
            }

            int[] rs = new int[0];
            int middleNumber = (int)Math.Floor(n / 2.0);
            for (int i = 1; i <= middleNumber; i++)
            {
                if (n % i == 0)
                {
                    Array.Resize(ref rs, rs.Length + 1);
                    rs[rs.Length - 1] = i;
                }
            }

            int composition = 1;
            int rsNumbers = rs.Length;
            for (int i = 0; i < rsNumbers; i++)
            {
                composition *= rs[i];
            }

            Console.WriteLine($"Bài số 22: Kết quả là {composition}");
        }
        
        private static void ProblemTwo(int n)
        {
            // đếm số lượng ước
            if (n <= 0)
            {
                Console.WriteLine("Bài số 23: Input n phải >= 1");
                return;
            }

            int[] rs = new int[0];
            int middleNumber = (int)Math.Floor(n / 2.0);
            for (int i = 1; i <= middleNumber; i++)
            {
                if (n % i == 0)
                {
                    Array.Resize(ref rs, rs.Length + 1);
                    rs[rs.Length - 1] = i;
                }
            }

            Console.WriteLine($"Bài số 23: Kết quả là {rs.Length}");
        }
        
        private static void ProblemThree(int n)
        {
            // liệt kê ước số lẻ
            if (n <= 0)
            {
                Console.WriteLine("Bài số 24: Input n phải >= 1");
                return;
            }

            int[] rs = new int[0];
            int middleNumber = (int)Math.Floor(n / 2.0);
            for (int i = 1; i <= middleNumber; i++)
            {
                if (n % i == 0 && i % 2 == 1)
                {
                    Array.Resize(ref rs, rs.Length + 1);
                    rs[rs.Length - 1] = i;
                }
            }

            string rsDisplay = String.Join(", ", rs);
            Console.WriteLine($"Bài số 24: Kết quả là [{rsDisplay}]");
        }
    }
}