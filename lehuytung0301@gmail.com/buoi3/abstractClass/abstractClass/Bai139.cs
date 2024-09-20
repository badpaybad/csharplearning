namespace abstractClass
{
    public class BaiTap139 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 6, 28, 12, 18, 5 };
            int lastPerfectIndex = Bai139Function(array);
            Console.WriteLine("Vị trí số hoàn thiện cuối cùng là: " + lastPerfectIndex);
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

        private int Bai139Function(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPerfect(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
