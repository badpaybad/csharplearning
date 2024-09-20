namespace abstractClass
{
    public class BaiTap144 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 8, 4, 9, 7, 11 };
            int firstPrime = Bai144Function(array);
            Console.WriteLine("Số nguyên tố đầu tiên là: " + firstPrime);
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

        private int Bai144Function(int[] array)
        {
            foreach (int value in array)
            {
                if (IsPrime(value))
                {
                    return value;
                }
            }
            return -1;
        }
    }
}
