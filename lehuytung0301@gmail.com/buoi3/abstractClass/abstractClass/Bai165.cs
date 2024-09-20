namespace abstractClass
{
    public class BaiTap165 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 246, 135, 789, 910 };
            int result = Bai165Function(array);
            Console.WriteLine("Giá trị đầu tiên có chữ số đầu tiên là lẻ: " + result);
        }

        private int Bai165Function(int[] array)
        {
            foreach (int value in array)
            {
                int firstDigit = GetFirstDigit(value);
                if (firstDigit % 2 != 0)
                {
                    return value;
                }
            }
            return 0;
        }

        private int GetFirstDigit(int number)
        {
            while (number >= 10)
            {
                number /= 10;
            }
            return number;
        }
    }
}
