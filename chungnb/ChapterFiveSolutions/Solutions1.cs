using SupportNamespace;

namespace Solutions1Namespace
{
     class Solutions1
    {
        public static void Solutions()
        {
            Console.WriteLine($"-- Các bài từ 122 tới 127 --");

            double rs122 = Solution122Input();
            SupportDisplay.Display(rs122, "Giá trị lớn nhất");
            
            int rs123 = Solution123Input();
            SupportDisplay.Display(rs123, "Vị trí số nguyên lớn nhất trong mảng");
            
            bool rs124 = Solution124Input();
            SupportDisplay.DisplayBool(rs124, "tồn tại số nguyên chẵn nhỏ hơn 2004");

            int rs125 = Solution125Input();
            SupportDisplay.Display(rs125, "Số lượng số nguyên tố nhỏ hơn 100 trong mảng");
            
            double rs126 = Solution126Input();
            SupportDisplay.Display(rs126, "Tổng các số thực âm trong mảng");

            double[] rs127 = Solution127Input();
            SupportDisplay.DisplayArrayDouble(rs127, "Mảng số thực sắp xếp tăng dần");
        }

        private static double Solution122Input()
        {
            Console.WriteLine("-- Bài 122-- ");
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

        private static int Solution123Input()
        {
            Console.WriteLine("-- Bài số 123 --");
            int[] arr  = SupportInputData.GetArrInt();
            int length = arr.Length;
            int index  = 0;
            int max    = 0;
            
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            return index;
        }

        private static bool Solution124Input()
        {
            Console.WriteLine("-- Bài số 124 --");
            int[] arr    = SupportInputData.GetArrInt();
            int length   = arr.Length;
            bool isExist = false;
            
            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < 2004)
                {
                    isExist = true;
                    break;
                }
            }
            
            return isExist;
        }

        private static int Solution125Input()
        {
            Console.WriteLine("-- Bài số 125 --");
            int[] arr  = SupportInputData.GetArrInt();
            int length = arr.Length;
            
            int countPrime = 0;
            for (int i = 0; i < length; i++)
            {
                if (SupportMath.IsPrime(arr[i]))
                {
                    countPrime++;
                }
            }

            return countPrime;
        }

        private static double Solution126Input()
        {
            Console.WriteLine("-- Bài số 126 --");
            double[] arr = SupportInputData.GetArrDouble();
            int length   = arr.Length;
            double sum   = 0.0;
            
            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        private static double[] Solution127Input()
        {
            Console.WriteLine("-- Bài số 127 --");
            double[] arr = SupportInputData.GetArrDouble();
            Array.Sort(arr);
            return arr;
        }
    }
}