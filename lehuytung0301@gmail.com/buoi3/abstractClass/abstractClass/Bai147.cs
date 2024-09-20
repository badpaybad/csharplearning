namespace abstractClass
{
    public class BaiTap147 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -3, 7, -9, 4, 5 };
            double lastPositive = Bai147Function(array);
            Console.WriteLine("Số dương cuối cùng là: " + lastPositive);
        }

        private double Bai147Function(double[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
