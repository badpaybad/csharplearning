namespace abstractClass
{
    public class BaiTap148 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 4, 5, 8, 9, 7 };
            int lastPrime = Bai148Function(array);
            Console.WriteLine("Số nguyên tố cuối cùng là: " + lastPrime);
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

        private int Bai148Function(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPrime(array[i]))
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
