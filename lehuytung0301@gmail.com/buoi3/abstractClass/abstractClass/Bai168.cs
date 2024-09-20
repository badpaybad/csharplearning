namespace abstractClass
{
    public class BaiTap168 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 25, 125, 150, 625 };
            int result = Bai168Function(array);
            Console.WriteLine("Giá trị lớn nhất có dạng 5^k là: " + result);
        }

        private int Bai168Function(int[] array)
        {
            int maxPowerOfFive = 0;
            foreach (int value in array)
            {
                if (IsPowerOfFive(value))
                {
                    if (value > maxPowerOfFive)
                    {
                        maxPowerOfFive = value;
                    }
                }
            }
            return maxPowerOfFive;
        }

        private bool IsPowerOfFive(int value)
        {
            while (value % 5 == 0 && value != 0)
            {
                value /= 5;
            }
            return value == 1;
        }
    }
}
