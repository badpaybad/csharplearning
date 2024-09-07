using SupportNamespace;
using ChungnbInterfaces;

namespace Solutions3Namespace
{
    class Solutions3: ISolution
    {
        public void Solutions()
        {
            Console.WriteLine($"-- Các bài từ 134 tới 141 --");
            
            double rs134 = Solution134Input();
            SupportDisplay.Display(rs134, "Giá trị lớn nhất trong mảng một chiều số thực");
            
            double rs135 = Solution135Input();
            SupportDisplay.Display(rs135, "Số dương đầu tiên trong mảng một chiều các số thực");
            
            int rs136 = Solution136Input();
            SupportDisplay.Display(rs136, "Số chẵn cuối cùng trong mảng một chiều các số nguyên");
            
            int rs137 = Solution137Input();
            SupportDisplay.Display(rs137, "Vị trí có giá trị nhỏ nhất trong mảng một chiều các số thực");
            
            int rs138 = Solution138Input();
            SupportDisplay.Display(rs138, "Vị trí số chẵn đầu tiên trong mảng một chiều các số nguyên");
            
            int rs139 = Solution139Input();
            SupportDisplay.Display(rs139, "Vị trí số hoàn thiện cuối cùng");
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

        private static int Solution137Input()
        {
            Console.WriteLine("-- Bài số 137 --");
            double[] arr = SupportInputData.GetArrDouble();
            int length   = arr.Length;
            double min   = arr[0];
            int position = 0;

            for (int i = 1; i < length; i++)
            {
                if (arr[i] < min)
                {
                    min      = arr[i];
                    position = i;
                }
            }

            return position;
        }

        private static int Solution138Input()
        {
            Console.WriteLine("-- Bài số 138 --");
            int[] arr    = SupportInputData.GetArrInt();
            int length   = arr.Length;
            int position = -1;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    position  = i;
                    break;
                }
            }

            return position;
        }

        private static int Solution139Input()
        {
            Console.WriteLine("-- Bài số 139 --");
            int[] arr    = SupportInputData.GetArrInt();
            int length   = arr.Length;
            int position = -1;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0 && SupportMath.IsPerfectNumber(arr[i]))
                {
                    position = i;
                }
            }

            return position;
        }
    }
}