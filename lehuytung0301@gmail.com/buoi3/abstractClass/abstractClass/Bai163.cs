namespace abstractClass
{
    public class BaiTap163 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 2, 4, 9, 16, 7 };
            int result = Bai163Function(array);
            Console.WriteLine("Số chính phương đầu tiên là: " + result);
        }

        private int Bai163Function(int[] array)
        {
            foreach (int value in array)
            {
                if (Math.Sqrt(value) == (int)Math.Sqrt(value))
                {
                    return value;
                }
            }
            return -1;
        }
    }
}
