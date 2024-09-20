namespace abstractClass
{
    public class BaiTap167 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 135, 579, 246, 1357 }; 
            int result = Bai167Function(array);
            Console.WriteLine("Giá trị lớn nhất toàn chữ số lẻ là: " + result);
        }

        private int Bai167Function(int[] array)
        {
            int maxOddDigitNumber = 0;
            foreach (int value in array)
            {
                if (AllDigitsAreOdd(value))
                {
                    if (value > maxOddDigitNumber)
                    {
                        maxOddDigitNumber = value;
                    }
                }
            }
            return maxOddDigitNumber;
        }

        private bool AllDigitsAreOdd(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    return false;
                }
                number /= 10;
            }
            return true;
        }
    }
}
