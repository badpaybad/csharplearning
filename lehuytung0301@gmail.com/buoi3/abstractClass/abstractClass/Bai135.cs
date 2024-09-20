namespace abstractClass
{
    public class BaiTap135 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -3.5, -7.2, 9.8, 4.6, -5.7 };
            double firstPositive = Bai135Function(array);
            Console.WriteLine("Giá trị dương đầu tiên là: " + firstPositive);
        }

        private double Bai135Function(double[] array)
        {
            foreach (double value in array)
            {
                if (value > 0)
                {
                    return value;
                }
            }
            return -1;
        }
    }
}
