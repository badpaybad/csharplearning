namespace abstractClass
{
    public class BaiTap143 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 1, 3, 5, 6, 7 };
            int firstEven = Bai143Function(array);
            Console.WriteLine("Số chẵn đầu tiên là: " + firstEven);
        }

        private int Bai143Function(int[] array)
        {
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    return value;
                }
            }
            return 1;
        }
    }
}
