using SupportNamespace;

namespace Solutions3Namespace
{
    class Solutions3
    {
        public static void Solutions()
        {
            Console.WriteLine($"-- Các bài từ 134 tới 141 --");
            
            double rs134 = Solution134Input();
            SupportDisplay.Display(rs134, "Giá trị lớn nhất trong mảng một chiều số thực");
            
            double rs135 = Solution135Input();
            SupportDisplay.Display(rs135, "Số dương đầu tiên trong mảng một chiều các số thực");
            
            int rs136 = Solution136Input();
            SupportDisplay.Display(rs136, "Số chẵn cuối cùng trong mảng một chiều các số nguyên");
        }

        private static double Solution134Input()
        {
            Console.WriteLine("-- Bài số 134 --");
            double[] arr = SupportInputData.GetArrDouble();
            int length   = arr.Length;
            double max   = 0.0;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private static double Solution135Input()
        {
            Console.WriteLine("-- Bài số 135 --");
            double[] arr = SupportInputData.GetArrDouble();
            int length   = arr.Length;
            double rs    = -1;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    rs = arr[i];
                    break;
                }
            }

            return rs;
        }

        private static int Solution136Input()
        {
            Console.WriteLine("-- Bài số 136 --");
            int[] arr    = SupportInputData.GetArrInt();
            int length   = arr.Length;
            int rs       = 1;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    rs = arr[i];
                }
            }

            return rs;
        }
    }
}