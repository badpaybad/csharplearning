namespace abstractClass
{
    public class BaiTap160 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -3, -0.5, -4, 1, -2 };
            double result = Bai160Function(array);
            Console.WriteLine("Giá trị âm cuối cùng lớn hơn -1 là: " + result);
        }

        private double Bai160Function(double[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0 && array[i] > -1)
                {
                    return array[i];
                }
            }
            return 0;
        }
    }
}
