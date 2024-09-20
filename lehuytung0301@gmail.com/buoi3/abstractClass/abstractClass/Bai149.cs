namespace abstractClass
{
    public class BaiTap149 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 10, 6, 28, 5 };
            int lastPerfect = Bai149Function(array);
            Console.WriteLine("Số hoàn thiện cuối cùng là: " + lastPerfect);
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

        private int Bai149Function(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPerfect(array[i]))
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
