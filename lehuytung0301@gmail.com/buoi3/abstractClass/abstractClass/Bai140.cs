namespace abstractClass
{
    public class BaiTap140 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -3, 7, -9, 4, 5 };
            double minPositive = Bai140Function(array);
            Console.WriteLine("Giá trị dương nhỏ nhất là: " + minPositive);
        }

        private double Bai140Function(double[] array)
        {
            double minPositive = -1;
            foreach (double value in array)
            {
                if (value > 0 && (minPositive == -1 || value < minPositive))
                {
                    minPositive = value;
                }
            }
            return minPositive;
        }
    }
}
