namespace abstractClass
{
    public class BaiTap169 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 2, 4, 5, 7, 3 };
            int result = Bai169Function(array);
            Console.WriteLine("Số chẵn lớn nhất nhỏ hơn mọi số lẻ là: " + result);
        }

        private int Bai169Function(int[] array)
        {
            int maxEven = int.MinValue;
            int minOdd = int.MaxValue;
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    if (value > maxEven)
                    {
                        maxEven = value;
                    }
                }
                else
                {
                    if (value < minOdd)
                    {
                        minOdd = value;
                    }
                }
            }

            return maxEven < minOdd ? maxEven : -1;
        }
    }
}
