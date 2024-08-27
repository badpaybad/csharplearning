namespace CSharpPractice;

public static class Utilities
{
    
    //method check input is positive number will return true, if user input -2 or not a number then return false
    public static bool IsPositiveNumber(string input)
    {
        return int.TryParse(input, out int number) && number > 0;
    }
    
    //method calculate sum from 1 to n
    public static int CalculateSum(int n)
    {
        return n * (n + 1) / 2;
    }
    
    //method calculate sum from 1 square to n square
    public static int CalculateSumSquare(int n)
    {
        return n * (n + 1) * (2 * n + 1) / 6;
    }
    
    //method calculate sum from 1/1 to 1/n
    public static double CalculateSumFraction(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }
        return sum;
    }
    
    //method calculate sum from 1/2 to 1/2*n
    public static double CalculateSumFraction2(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / (2 * i);
        }
        return sum;
    }
    
    //method calculate sum from 1/1 to 1/(2*n + 1)
    public static double CalculateSumFraction3(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / (2 * i + 1);
        }
        return sum;
    }
    
    //method calculate sum from 1/(1*2) + 1/(2*3) + ... + 1/n*(n*1)
    public static double CalculateSumFraction4(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / (i * (i + 1));
        }
        return sum;
    }
    
    //method calculate sum from 1/2 + 2/3 + 3/4 + ... + n/(n+1)
    public static double CalculateSumFraction5(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i / (i + 1.0);
        }
        return sum;
    }
    
    //method calculate sum of 1/2 + 3/4 + 5/6 + ... + (2n+1)/(2n+2)
    public static double CalculateSumFraction6(int n)
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += (2 * i + 1) / (2 * i + 2.0);
        }
        return sum;
    }
    
    //method calculate sum of 1*2*3*...*n
    public static int CalculateFactorial(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    
    //method calculate sum of 1 + 1*2 + 1*2*3 + ... + 1*2*3*...*n
    public static int CalculateSumFactorial(int n)
    {
        int sum = 0;
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial;
        }
        return sum;
    }
    
    //method calculate x^n
    public static double CalculatePower(double x, int n)
    {
        double result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= x;
        }
        return result;
    }
    
    //method calculate sum of x^1 + x^2 + x^3 + ... + x^n
    public static double CalculateSumPower(double x, int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += CalculatePower(x, i);
        }
        return sum;
    }
    
    //method calculate sum of x^2 + x^4 + ... + x^2*n
    public static double CalculateSumPower2(double x, int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += CalculatePower(x, 2 * i);
        }
        return sum;
    }
    
    //method calculate sum of x^1 + x^3 + ... + x^(2*n+1)
    public static double CalculateSumPower3(double x, int n)
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += CalculatePower(x, 2 * i + 1);
        }
        return sum;
    }
    
    //method calculate sum of 1 + 1/(1+2) + 1/(1+2+3) + ... + 1/(1+2+3+...+n)
    public static double CalculateSumFraction7(int n)
    {
        double sum = 0;
        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += i;
            sum += 1.0 / total;
        }
        return sum;
    }
    
    //method calculate sum of x + x^2/(1+2) + x^3/(1+2+3) + ... + x^n/(1+2+3+...+n)
    public static double CalculateSumFraction8(double x, int n)
    {
        double sum = 0;
        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += i;
            sum += CalculatePower(x, i) / total;
        }
        return sum;
    }
    
    //method calculate sum of x + x^2/2! + x^3/3! + ... + x^n/n!
    public static double CalculateSumFraction9(double x, int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += CalculatePower(x, i) / CalculateFactorial(i);
        }
        return sum;
    }
    
    //method calculate sum of 1 + x^2/2! + x^4/4! + ... + x^2*n/(2*n)!
    public static double CalculateSumFraction10(double x, int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += CalculatePower(x, 2 * i) / CalculateFactorial(2 * i);
        }
        return sum;
    }
    
    //method calculate sum of 1 + x + x^3/3! + x^5/5! + ... + x^(2*n+1)/(2*n+1)!
    public static double CalculateSumFraction11(double x, int n)
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += CalculatePower(x, 2 * i + 1) / CalculateFactorial(2 * i + 1);
        }
        return sum;
    }
    
    //method List all the “divisors” of the positive integer n
    public static List<int> ListDivisors(int n)
    {
        List<int> divisors = new();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
    }
    
    //method calculate sum of divisors of n
    public static int CalculateSumDivisors(int n)
    {
        return ListDivisors(n).Sum();
    }
    
    //method calculate product of divisors of n
    public static int CalculateProductDivisors(int n)
    {
        return ListDivisors(n).Aggregate((a, b) => a * b);
    }
    
    //method count number of divisors of n
    public static int CountDivisors(int n)
    {
        return ListDivisors(n).Count;
    }
    
    //method List all the “odd divisors” of the positive integer n
    public static List<int> ListOddDivisors(int n)
    {
        List<int> divisors = new();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0 && i % 2 != 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
    }
    
    //method List all the “even divisors” of the positive integer n
    public static List<int> ListEvenDivisors(int n)
    {
        List<int> divisors = new();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0 && i % 2 == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
    }
    
    //method calculate sum of odd divisors of n
    public static int CalculateSumOddDivisors(int n)
    {
        return ListOddDivisors(n).Sum();
    }
    
    //method calculate sum of even divisors of n
    public static int CalculateSumEvenDivisors(int n)
    {
        return ListEvenDivisors(n).Sum();
    }
    
    //method calculate product of odd divisors of n
    public static int CalculateProductOddDivisors(int n)
    {
        return ListOddDivisors(n).Aggregate((a, b) => a * b);
    }
    
    //method count number of odd divisors of n
    public static int CountOddDivisors(int n)
    {
        return ListOddDivisors(n).Count;
    }
}