namespace abstractClass
{
    public class BaiTap152 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 28, 6, 12 };
            int minPerfect = Bai152Function(array);
            Console.WriteLine("Số hoàn thiện nhỏ nhất là: " + minPerfect);
        }

        private bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }

        private int Bai152Function(int[] array)
        {
            int minPerfect = 0;
            foreach (int value in array)
            {
                if (IsPerfect(value) && (minPerfect == 0 || value < minPerfect))
                {
                    minPerfect = value;
                }
            }
            return minPerfect;
        }
    }
}
