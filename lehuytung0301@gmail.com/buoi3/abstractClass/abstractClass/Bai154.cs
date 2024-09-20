namespace abstractClass
{
    public class BaiTap154 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 3, 7, 5, 9, 4 };
            int maxOdd = Bai154Function(array);
            Console.WriteLine("Giá trị lẻ lớn nhất là: " + maxOdd);
        }

        private int Bai154Function(int[] array)
        {
            int maxOdd = -1;
            foreach (int value in array)
            {
                if (value % 2 != 0 && value > maxOdd)
                {
                    maxOdd = value;
                }
            }
            return maxOdd;
        }
    }
}
