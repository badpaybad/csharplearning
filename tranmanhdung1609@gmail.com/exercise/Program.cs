using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double result = Bai1(n);
            Console.WriteLine(result);
        }

        static int Bai1(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int Bai2(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        static double Bai3(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;

            }
            return sum;
        }

        static double Bai4(int n)
        {
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += 1 / (2 * i);
            }
            return S;
        }

        static double Bai5(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += 1 / (2 * i + 1);
            }
            return sum;
        }

        static double Bai6(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (i * (i + 1));
            }
            return sum;
        }

        static double Bai7(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i / (i + 1);
            }
            return sum;
        }

        static double Bai8(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += ((2 * i) + 1) / ((2 * i) + 2);
            }
            return sum;
        }

        static long Bai9(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static double Bai10(int x, int n)
        {
            double result = Math.Pow(x, n);

            return result;
        }

        static long Bai11(int n)
        {
            long sum = 0;
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }

            return sum;
        }

        static double Bai12(int n, int x)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i);
            }

            return sum;
        }

        static double Bai13(int n)
        {
            double sum = 0;
            for(int  i = 1; i <= n; i++)
            {
                sum += Math.Pow(2, 2 * i);
            }
            return sum;
        }


        static double Bai14(int n)
        {
            double sum = 0;
            for (int  i = 0; i <= n; i++)
            {
                sum += Math.Pow(2, ((2 * i) + 1));
            }

            return sum;
        }


        static double Bai15(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double innerSum = 0;
                for (int j = 1; j <= i; j++)
                {
                    innerSum += j;
                }
                sum += 1 / innerSum;
            }

            sum += 1;
            return sum;
        }
        
        static double Bai16(int n,int x)
        {
            double sum = x; // Khởi tạo sum với giá trị x (số hạng đầu tiên)

            for (int i = 2; i <= n; i++)
            {
                double innerSum = 0;
                for (int j = 1; j <= i; j++)
                {
                    innerSum += j;
                }
                sum += Math.Pow(x, i) / innerSum;
            }

            return sum;
        }

        static long GiaiThua(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static double Bai17(int n, double x)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i) / GiaiThua(i);
            }

            return sum;
        }


        static double Bai19(int n, double x)
        {
            double sum = 1;

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, (2* i)+1) / GiaiThua((2 * i) + 1);
            }

            return sum;
        }

        static double Bai18(int n, double x)
        {
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, 2 * i) / GiaiThua(2 * i);
            }

            return sum;
        }


        static int[] Bai20(int n)
        {
            List<int> uocSoList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    uocSoList.Add(i);
                }
            }

            return uocSoList.ToArray();
        }

        static int Bai21(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static long Bai22(int n)
        {
            long product = 1;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    product *= i;
                }
            }

            return product;
        }

        static long Bai23(int n)
        {
            long product = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    product++;
                }
            }

            return product;
        }

        static int[] bai24(int n)
        {
            List<int> array = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                    array.Add(i);
                }
            }

            return array.ToArray();
        }

        static double bai25(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static double Bai26(int n)
        {
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                    sum *= i;
                }
            }
            return sum;
        }

        static double bai27(int n)
        {
            double soluong = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    soluong++;
                }
            }

            return soluong;
        }

        static int Bai28(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static int bai29(int n)
        {
            int largestOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                    if (i > largestOdd)
                    {
                        largestOdd = i;
                    }
                }
            }

            return largestOdd;
        }

        static string Bai30(int n)
        {
    
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                return n + " là số hoàn thiện";
            }
            else
            {
                return n + " là số không hoàn thiện";
            }
        }


        static int Bai43(int n)
        {
            return n.ToString().Length;
        }

        static int Bai44(int n)
        {
            int sum = 0;
            // int sum = SumOfDigits(n);

            while (n != 0)
            {
                sum += n % 10;  // Lấy chữ số cuối cùng
                n /= 10;        // Loại bỏ chữ số cuối cùng
            }

            return sum;
        }

        static int Bai45(int n)
        {
            int product = 1;

            while (n != 0)
            {
                product *= n % 10;  // Lấy chữ số cuối cùng và nhân vào tích
                n /= 10;            // Loại bỏ chữ số cuối cùng
            }

            return product;
        }

        static int Bai46(int n)
        {
            int oddCount = 0;

            while (n != 0)
            {
                int digit = n % 10;  // Lấy chữ số cuối cùng

                if (digit % 2 != 0)  // Kiểm tra nếu chữ số là lẻ
                {
                    oddCount++;
                }

                n /= 10;  // Loại bỏ chữ số cuối cùng
            }

            return oddCount;
        }

        static int Bai47(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                int digit = n % 10;  // Lấy chữ số cuối cùng

                if (digit % 2 == 0)  // Kiểm tra nếu chữ số là chẵn
                {
                    sum += digit;    // Cộng chữ số chẵn vào tổng
                }

                n /= 10;  // Loại bỏ chữ số cuối cùng
            }

            return sum;
        }

        static int Bai48(int n)
        {
            int product = 1;
            bool hasOddDigits = false;

            while (n != 0)
            {
                int digit = n % 10;  // Lấy chữ số cuối cùng

                if (digit % 2 != 0)  // Kiểm tra nếu chữ số là lẻ
                {
                    product *= digit;  // Nhân chữ số lẻ vào tích
                    hasOddDigits = true;
                }

                n /= 10;  // Loại bỏ chữ số cuối cùng
            }

            return hasOddDigits ? product : 0;
        }

        static int Bai49(int n)
        {
            while (n >= 10)
            {
                n /= 10;
            }
            return n;
        }

        static int Bai50(int n)
        {
            int reversed = 0;

            while (n != 0)
            {
                int digit = n % 10;  // Lấy chữ số cuối cùng của n
                reversed = reversed * 10 + digit;  // Thêm chữ số vào số đảo ngược
                n /= 10;  // Loại bỏ chữ số cuối cùng của n
            }

            return reversed;
        }

        static int Bai51(int n)
        {
            int maxDigit = 0;

            while (n != 0)
            {
                int digit = n % 10;  // Lấy chữ số cuối cùng của n
                if (digit > maxDigit)
                {
                    maxDigit = digit;  // Cập nhật chữ số lớn nhất nếu cần
                }
                n /= 10;  // Loại bỏ chữ số cuối cùng của n
            }

            return maxDigit;
        }

        static int Bai52(int n)
        {
            // Khởi tạo maxDigit với giá trị lớn nhất có thể (9)
            int minDigit = 9;

            while (n != 0)
            {
                int digit = n % 10;  // Lấy chữ số cuối cùng của n
                if (digit < minDigit)
                {
                    minDigit = digit;  // Cập nhật chữ số nhỏ nhất nếu cần
                }
                n /= 10;  // Loại bỏ chữ số cuối cùng của n
            }

            return minDigit;
        }


        static int Bai53(int n)
        {
            int maxDigit = 0;
            int maxDigitCount = 0;

            // Tìm chữ số lớn nhất
            int temp = n;
            while (temp != 0)
            {
                int digit = temp % 10;  // Lấy chữ số cuối cùng
                if (digit > maxDigit)
                {
                    maxDigit = digit;  // Cập nhật chữ số lớn nhất
                }
                temp /= 10;  // Loại bỏ chữ số cuối cùng
            }

            // Đếm số lần xuất hiện của chữ số lớn nhất
            temp = n;
            while (temp != 0)
            {
                int digit = temp % 10;  // Lấy chữ số cuối cùng
                if (digit == maxDigit)
                {
                    maxDigitCount++;  // Tăng số lần xuất hiện
                }
                temp /= 10;  // Loại bỏ chữ số cuối cùng
            }

            return maxDigitCount;
        }

        static int Bai54(int n)
        {
            int minDigit = 9;
            int minDigitCount = 0;

            // Tìm chữ số nhỏ nhất
            int temp = n;
            while (temp != 0)
            {
                int digit = temp % 10;  // Lấy chữ số cuối cùng
                if (digit < minDigit)
                {
                    minDigit = digit;  // Cập nhật chữ số nhỏ nhất
                }
                temp /= 10;  // Loại bỏ chữ số cuối cùng
            }

            // Đếm số lần xuất hiện của chữ số nhỏ nhất
            temp = n;
            while (temp != 0)
            {
                int digit = temp % 10;  // Lấy chữ số cuối cùng
                if (digit == minDigit)
                {
                    minDigitCount++;  // Tăng số lần xuất hiện
                }
                temp /= 10;  // Loại bỏ chữ số cuối cùng
            }

            return minDigitCount;
        }


    }
}

