using SupportNamespace;
using ChungnbInterfaces;

namespace Solutions2Namespace
{
     class Solutions2: ISolution
    {
        public void Solutions()
        {
            Console.WriteLine($"-- Các bài từ 128 tới 133 --");

            double[] rs128 = Solution128Input();
            SupportDisplay.DisplayArrayDouble(rs128, "Mảng một chiều các số thực");
            
            int[] rs129 = Solution129Input();
            SupportDisplay.DisplayArrayInt(rs129, "Mảng một chiều các số nguyên");

            double[] rs130 = { 1, 1, 1, 3, 1, 5 };
            Solution130Input(rs130);

            int[] rs131 = { 1, 2, 3 };
            Solution131Input(rs131);
            
            int[] rs132 = Solution132Input();
            SupportDisplay.DisplayArrayInt(rs132, "Các giá trị chẵn trong mảng một chiều các số nguyên");
            
            int[] rs133 = Solution133Input();
            SupportDisplay.DisplayArrayInt(rs133, "Vị trí các giá trị âm trong mảng một chiều các số thực");
        }

        private static double[] Solution128Input()
        {
            Console.WriteLine("-- Bài số 128 --");
            return SupportInputData.GetArrDouble();
        }

        private static int[] Solution129Input()
        {
            Console.WriteLine("-- Bài số 129 --");
            return SupportInputData.GetArrInt();
        }

        private static void Solution130Input(double[] arr)
        {
            Console.WriteLine("-- Bài số 130 --");
            SupportDisplay.DisplayArrayDouble(arr, "Mảng một chiều các số thực");
        }

        private static void Solution131Input(int[] arr)
        {
            Console.WriteLine("-- Bài số 131 --");
            SupportDisplay.DisplayArrayInt(arr, "Mảng một chiều các số nguyên");
        }

        private static int[] Solution132Input()
        {
            Console.WriteLine("-- Bài số 132 --");
            int[] arr      = SupportInputData.GetArrInt();
            int length     = arr.Length;
            List<int> list = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    list.Add(arr[i]);
                }
            }
            
            return list.ToArray();
        }
        
        private static int[] Solution133Input()
        {
            Console.WriteLine("-- Bài số 133 --");
            double[] arr      = SupportInputData.GetArrDouble();
            int length        = arr.Length;
            List<int> list = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0)
                {
                    list.Add(i);
                }
            }
            
            return list.ToArray();
        }
    }
}