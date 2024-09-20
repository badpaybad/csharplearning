namespace abstractClass
{
    public class BaiTap170 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 2, 5, 10, 15 };
            int result = Bai170Function(array);
            Console.WriteLine("Số nguyên tố nhỏ nhất lớn hơn mọi giá trị trong mảng là: " + result);
        }

        private int Bai170Function(int[] array)
        {
            int max = array.Max();
            int candidate = max + 1;
            while (!IsPrime(candidate))
            {
                candidate++;
            }
            return candidate;
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
