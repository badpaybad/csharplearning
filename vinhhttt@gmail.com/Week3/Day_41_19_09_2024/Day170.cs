namespace Week3.Day_41_18_09_2024
{
    public class Bai170 : Homework
    {
        public override void Run()
        {
            int[] intArray = InputIntArray.GetInputIntArray();
            int max = FindMax(intArray);
            int nextPrime = FindNextPrime(max);
            Console.WriteLine("So nguyen to nho nhat lon hon moi gia tri trong mang la: " + nextPrime);
        }

        private int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private int FindNextPrime(int n)
        {
            int prime = n + 1;
            while (!IsPrime(prime))
            {
                prime++;
            }
            return prime;
        }
    }
}