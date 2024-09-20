namespace abstractClass
{
    public class BaiTap161 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            int x = 15, y = 35;
            int result = Bai161Function(array, x, y);
            Console.WriteLine("Giá trị đầu tiên trong khoảng (" + x + ", " + y + ") là: " + result);
        }

        private int Bai161Function(int[] array, int x, int y)
        {
            foreach (int value in array)
            {
                if (value > x && value < y)
                {
                    return value;
                }
            }
            return x;
        }
    }
}
