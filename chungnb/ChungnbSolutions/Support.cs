namespace SupportNamespace
{
    class Support
    {
        public static int factorialCal(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Để tính giai thừa, input phải >= 0");
                return -1;
            }

            int rs   = 1;
            for (int i = 1; i <= n; i++)
            {
                rs *= i;
            }

            return rs;
        }
    }
}