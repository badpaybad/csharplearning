namespace abstractClass
{
    public class BaiTap145 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 10, 28, 6, 9 };
            int firstPerfect = Bai145Function(array);
            Console.WriteLine("Số hoàn thiện đầu tiên là: " + firstPerfect);
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

        private int Bai145Function(int[] array)
        {
            foreach (int value in array)
            {
                if (IsPerfect(value))
                {
                    return value;
                }
            }
            return -1;
        }
    }
}
