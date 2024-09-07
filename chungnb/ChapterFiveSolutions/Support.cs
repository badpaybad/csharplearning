namespace SupportNamespace
{
    class SupportInputData
    {
        public static int[] GetArrInt()
        {
            int length = GetArrLength();

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhập số nguyên thứ {i+1}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            return arr;
        }

        public static double[] GetArrDouble()
        {
            int length = GetArrLength();

            double[] arr = new double[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhập số thực thứ {i+1}, ngăn cách thập phân bằng dấu ',': ");
                double.TryParse(Console.ReadLine(), out arr[i]);
            }

            return arr;
        }
        
        private static int GetArrLength()
        {
            Console.Write("Nhập số phần tử của mảng: ");
            int.TryParse(Console.ReadLine(), out int length);
            CheckArrLength(length);
            return length;
        }
        
        private static void CheckArrLength(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine("Số phần tử của mảng phải >= 1");
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    
    class SupportDisplay
    {
        public static void Display(object value, string message = "Kết quả là")
        {
            Console.WriteLine($"{message}: {value}");
        }

        public static void DisplayBool(bool isTrue, string message = "tồn tại giá trị")
        {
            string confirmation = isTrue ? "Có" : "Không";
            Console.WriteLine($"{confirmation} {message}");
        }
        
        public static void DisplayArrayDouble(double[] value, string message = "Mảng các số thực")
        {
            Console.WriteLine($"{message}: [{string.Join(" ", value)}]");
        }
        
        public static void DisplayArrayInt(int[] value, string message = "Mảng các số nguyên")
        {
            Console.WriteLine($"{message}: [{string.Join(" ", value)}]");
        }
    }

    class SupportMath
    {
        public static bool IsPrime(int number)
        {
            int half     = (int)(number / 2);
            bool isPrime = true;
            for (int i = 2; i <= half; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        public static bool IsPerfectNumber(int number)
        {
            int[] wishes    = GetNumberWishes(number);
            int countWishes = wishes.Length;
            int sum         = 0;

            for (int i = 0; i < countWishes; i++)
            {
                sum += wishes[i];
            }

            return number == sum;
        }

        public static int[] GetNumberWishes(int number)
        {
            int half         = number / 2;
            List<int> wishes = new List<int>();

            for (int i = 1; i <= half; i++)
            {
                if (number % i == 0)
                {
                    wishes.Add(i);
                }
            }
            
            return wishes.ToArray();
        }
    }
}