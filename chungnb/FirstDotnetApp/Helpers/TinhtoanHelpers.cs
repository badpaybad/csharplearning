namespace TinhToan.Helpers
{
    public class TinhToanHelpers
    {
        // Lấy chữ số đầu tiên
        public static int LayChuSoDauTien(int number)
        {
            while (number >= 10)
            {
                number /= 10;
            }
            return number;
        }

        // Kiểm tra số nguyên tố
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
