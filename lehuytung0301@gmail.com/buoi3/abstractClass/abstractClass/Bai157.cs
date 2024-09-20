namespace abstractClass
{
    public class BaiTap157 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 3, 5, 7, 9, 4 };
            (double a, double b) = Bai157Function(array);
            Console.WriteLine("Đoạn [a, b] chứa tất cả giá trị là: [" + a + ", " + b + "]");
        }

        private (double, double) Bai157Function(double[] array)
        {
            double min = array[0];
            double max = array[0];
            foreach (double value in array)
            {
                if (value < min) min = value;
                if (value > max) max = value;
            }
            return (min, max);
        }
    }
}
