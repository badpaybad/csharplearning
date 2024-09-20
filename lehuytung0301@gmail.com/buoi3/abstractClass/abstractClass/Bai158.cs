namespace abstractClass
{
    public class BaiTap158 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -2, 5, -7, 9, 4 };
            double x = Bai158Function(array);
            Console.WriteLine("Giá trị x để đoạn [-x, x] chứa tất cả giá trị là: " + x);
        }

        private double Bai158Function(double[] array)
        {
            double maxAbs = Math.Abs(array[0]);
            foreach (double value in array)
            {
                if (Math.Abs(value) > maxAbs)
                {
                    maxAbs = Math.Abs(value);
                }
            }
            return maxAbs;
        }
    }
}
