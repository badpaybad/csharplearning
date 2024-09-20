namespace abstractClass
{
    public class BaiTap164 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 12321, 456, 789, 123 };
            int result = Bai164Function(array);
            Console.WriteLine("Số gánh đầu tiên là: " + result);
        }

        private int Bai164Function(int[] array)
        {
            foreach (int value in array)
            {
                if (IsPalindrome(value.ToString()))
                {
                    return value;
                }
            }
            return -1;
        }

        private bool IsPalindrome(string value)
        {
            int length = value.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (value[i] != value[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
