
int bai16(int n)
{
    int sum = 0;
    if (n == 0)
    {
        return sum;
    }
    sum = n * (n + 1) / 2;
    return sum;
}

Console.WriteLine($"bai tap 1: {bai1(6)}");




        double bai16(int n, int x)
        {
            double sum          = 0;

            if (n == 0)
            {
                return sum;
            }

            double numerator   = 0;
            double denominator = 0;
            for (int i = 1; i <= n; i++)
            {
                numerator = Math.Pow(x, i);
                denominator += i;
                sum += numerator / denominator;
            }

            return sum
        }
        Console.WriteLine($"bai tap 16: {bai16(6, 4)}");

        double bai17(int n, int x)
        {
            double sum        = 0;

            if (n < 0)
            {
                return sum;
            }

            double numerator = 0;
            for (int i = 1; i <= n; i++)
            {
                numerator       = Math.Pow(x, 2 * i);
                int denominator = Support.factorialCal(2 * i);
                sum += numerator / denominator;
            }

            return sum;
        }


        Console.WriteLine($"bai tap 17: {bai17(6, 4)}");




        double bai18(int n, int x)
        {
            double numerator;
            double dominator;
            double sum = 1;
            if (n < 0)
            {
                return sum;
            }
            for (int i = 0; i <= n; i++)
            {
                numerator = Math.Pow(x, 2 * i);
                dominator = Support.factorialCal(2 * i);
                sum += numerator / dominator;
            }

            return sum;

        }
        Console.WriteLine($"bai tap 18: {bai18(6, 4)}");


        

        private static void bai19(int n, int x)
        {
            double sum = 1;
            if (n < 0)
            {
                return sum;
            }
            for (int i = 0; i <= n; i++)
            {
                double numerator   = Math.Pow(x, 2 * i + 1);
                double denominator = Support.factorialCal(2 * i + 1);
                sum += numerator / denominator;
            }

            return sum;
        }

        Console.WriteLine($"bai tap 19: {bai19(6, 4)}");

        Array bai20(int n)
        {
            List<int> arrayRs = new List<int>();
            // tìm danh sách ước
            if (n <= 0)
            {
                return [0];
            }

            
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   arrayRs.Add(i)
                }
            }

            return arrayRs.ToArray();
        }


        Console.WriteLine($"bai tap 20: {bai20(6)}");

        int bai21(int n)
        {
            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   sum += i
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 21: {bai21(6)}");

        double bai22(int n)
        {
            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   sum *= i
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 22: {bai22(6)}");


        double bai23(int n)
        {
            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   sum++
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 23: {bai23(6)}");


        double bai24(int n)
        {
            List<int> arrayRs = new List<int>();
            // tìm danh sách ước
            if (n <= 0)
            {
                return [0];
            }

            
            for (int i = 1; i <= n; i++)
            {
                if if (n % i == 0 && i % 2 != 0)
                {
                   arrayRs.Add(i)
                }
            }

            return arrayRs.ToArray();
        }

        Console.WriteLine($"bai tap 24: {bai24(6)}");

        double bai25(int n)
        {
           

            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                   sum += i;
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 25: {bai25(6)}");


        double bai26(int n)
        {
           

            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                   sum *= i;
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 26: {bai26(6)}");


        double bai27(int n)
        {
           

            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                   sum ++;
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 27: {bai27(6)}");


        double bai28(int n)
        {
           

            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                   sum ++;
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 28: {bai28(6)}");


        double bai29(int n)
        {
           

            int sum = -1; 

            if (n <= 0)
            {
                return -1; 
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0) 
                {
                    if (i > sum) 
                    {
                        sum = i;
                    }
                }
            }

            return sum;
        }

        Console.WriteLine($"bai tap 29: {bai29(6)}");


        double bai30(int n)
        {
           

            int sum = 0;
            if (n <= 0)
            {
                return sum;
            }

            for (int i = 1; i <= n; i++){
                if (n % i == 0 && i % 2 != 0) {
                    if (i > uocSoLeLonNhat) 
                        {
                            uocSoLeLonNhat = i;
                        }
                    }
                }

            return sum;
        }

        Console.WriteLine($"bai tap 30: {bai30(6)}");