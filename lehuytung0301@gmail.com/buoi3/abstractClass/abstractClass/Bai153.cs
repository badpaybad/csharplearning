namespace abstractClass
{
    public class BaiTap153 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 4, 12, 8, 6, 5 };
            int minEven = Bai153Function(array);
            Console.WriteLine("Giá trị chẵn nhỏ nhất là: " + minEven);
        }

        private int Bai153Function(int[] array)
        {
            int minEven = -1;
            foreach (int value in array)
            {
                if (value % 2 == 0 && (minEven == -1 || value < minEven))
                {
                    minEven = value;
                }
            }
            return minEven;
        }
    }
}
