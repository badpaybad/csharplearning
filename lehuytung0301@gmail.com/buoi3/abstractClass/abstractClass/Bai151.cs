namespace abstractClass
{
    public class BaiTap151 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 2, 11, 4, 7 };
            int maxPrime = Bai151Function(array);
            Console.WriteLine("Số nguyên tố lớn nhất là: " + maxPrime);
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private int Bai151Function(int[] array)
        {
            int maxPrime = 0;
            foreach (int value in array)
            {
                if (IsPrime(value) && value > maxPrime)
                {
                    maxPrime = value;
                }
            }
            return maxPrime;
        }
    }
}
