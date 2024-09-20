namespace abstractClass
{
    public class BaiTap146 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 3, -4, 5, -9 };
            double firstNegative = Bai146Function(array);
            Console.WriteLine("Giá trị âm đầu tiên là: " + firstNegative);
        }

        private double Bai146Function(double[] array)
        {
            foreach (double value in array)
            {
                if (value < 0)
                {
                    return value;
                }
            }
            return 1;
        }
    }
}
