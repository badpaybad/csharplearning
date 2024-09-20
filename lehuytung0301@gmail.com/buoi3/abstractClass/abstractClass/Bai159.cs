namespace abstractClass
{
    public class BaiTap159 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 1800, 2050, 3000, 1500 };
            double result = Bai159Function(array);
            Console.WriteLine("Giá trị đầu tiên lớn hơn 2003 là: " + result);
        }

        private double Bai159Function(double[] array)
        {
            foreach (double value in array)
            {
                if (value > 2003)
                {
                    return value;
                }
            }
            return 0;
        }
    }
}
