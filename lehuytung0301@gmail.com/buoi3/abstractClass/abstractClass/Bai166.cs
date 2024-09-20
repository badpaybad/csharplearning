namespace abstractClass
{
    public class BaiTap166 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 3, 8, 16, 10 };
            int result = Bai166Function(array);
            Console.WriteLine("Giá trị đầu tiên dạng 2^k là: " + result);
        }

        private int Bai166Function(int[] array)
        {
            foreach (int value in array)
            {
                if (IsPowerOfTwo(value))
                {
                    return value;
                }
            }
            return 0;
        }

        private bool IsPowerOfTwo(int value)
        {
            return (value > 0) && ((value & (value - 1)) == 0);
        }
    }
}
