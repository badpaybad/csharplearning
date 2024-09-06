namespace DayTenNamespace
{
    class DayTen
    {
        private const int Day = 10;
        
        public static void Solutions()
        {
            Console.WriteLine($"-- Các bài từ 122 tới 127 --");

            double max = Solution1Input();
            Solution1Output(max);
            
            int index = Solution2Input();
            Solution2Output(index);
            
            bool isExist = Solution3Input();
            Solution3Output(isExist);
        }

        private static double Solution1Input()
        {
            Console.WriteLine("-- Bài 122-- ");
            Console.Write("Nhập số phần tử của mảng: ");
            int.TryParse(Console.ReadLine(), out int length);
            if (length <= 0)
            {
                Console.WriteLine("Chiều dài mảng phải >= 1");
                throw new ArgumentOutOfRangeException();
            }

            double[] arr = new double[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i+1}, ngăn cách thập phân bằng dấu ',': ");
                double.TryParse(Console.ReadLine(), out arr[i]);
            }

            double max = 0.0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private static void Solution1Output(double max)
        {
            Console.WriteLine($"Giá trị lớn nhất: {max}");
        }

        private static int Solution2Input()
        {
            Console.WriteLine("-- Bài số 123 --");
            Console.Write("Nhập số phần tử của mảng: ");
            int.TryParse(Console.ReadLine(), out int length);
            if (length <= 0)
            {
                Console.WriteLine("Chiều dải của mảng phải >= 1");
                throw new ArgumentOutOfRangeException();
            }

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i+1}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            int index = 0;
            int max   = 0;
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

        private static void Solution2Output(int index)
        {
            Console.WriteLine($"Vị trí của số nguyên lớn nhất trong mảng: {index}");
        }

        private static bool Solution3Input()
        {
            Console.WriteLine("-- Bài số 124 --");
            Console.Write("Nhập số phần tử của mảng: ");
            int.TryParse(Console.ReadLine(), out int length);
            if (length <= 0)
            {
                Console.WriteLine("Chiều dài mảng phải >= 1");
                throw new ArgumentOutOfRangeException();
            }

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i+1}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

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

        private static void Solution3Output(bool isExist)
        {
            string result = isExist ? "Có" : "Không";
            Console.WriteLine($"{result} tồn tại số nguyên chẵn nhỏ hơn 2004");
        }
    }
}