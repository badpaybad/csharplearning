namespace abstractClass
{
    public class BaiTap150 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -3, -7, -1, -9 };
            double maxNegative = Bai150Function(array);
            Console.WriteLine("Giá trị âm lớn nhất là: " + maxNegative);
        }

        private double Bai150Function(double[] array)
        {
            double maxNegative = 0;
            foreach (double value in array)
            {
                if (value < 0 && (maxNegative == 0 || value > maxNegative))
                {
                    maxNegative = value;
                }
            }
            return maxNegative;
        }
    }
}
