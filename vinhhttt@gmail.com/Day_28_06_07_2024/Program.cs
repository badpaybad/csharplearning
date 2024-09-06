using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Tim so hoan thien cuoi cung trong mang mot chieu so nguyen.");
        Console.WriteLine("2. Tim gia tri am lon nhat trong mang mot chieu so thuc.");
        Console.WriteLine("3. Tim so nguyen to lon nhat trong mang mot chieu so nguyen.");
        Console.Write("Nhap lua chon cua ban (1/2/3): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Lua chon khong hop le. Vui long nhap lai (1/2/3): ");
        }

        switch (choice)
        {
            case 1:
                int[] intArray = InputIntArray();
                int lastPerfect = FindLastPerfectNumber(intArray);
                if (lastPerfect == -1)
                {
                    Console.WriteLine("Mang khong co so hoan thien.");
                }
                else
                {
                    Console.WriteLine("So hoan thien cuoi cung trong mang la: " + lastPerfect);
                }
                break;

            case 2:
                float[] floatArray = InputFloatArray();
                float maxNegative = FindMaxNegativeNumber(floatArray);
                if (maxNegative == 0)
                {
                    Console.WriteLine("Mang khong co gia tri am.");
                }
                else
                {
                    Console.WriteLine("Gia tri am lon nhat trong mang la: " + maxNegative);
                }
                break;

            case 3:
                int[] intArrayForPrime = InputIntArray();
                int maxPrime = FindMaxPrimeNumber(intArrayForPrime);
                if (maxPrime == 0)
                {
                    Console.WriteLine("Mang khong co so nguyen to.");
                }
                else
                {
                    Console.WriteLine("So nguyen to lon nhat trong mang la: " + maxPrime);
                }
                break;
        }
    }

    static int[] InputIntArray()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong cho so luong phan tu: ");
        }

        int[] array = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array[{i}] = ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Vui long nhap mot so nguyen hop le: ");
            }
            array[i] = value;
        }
        return array;
    }

    static float[] InputFloatArray()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong cho so luong phan tu: ");
        }

        float[] array = new float[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array[{i}] = ");
            float value;
            while (!float.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Vui long nhap mot so thuc hop le: ");
            }
            array[i] = value;
        }
        return array;
    }
    // 149
    static int FindLastPerfectNumber(int[] array)
    {
        int lastPerfect = -1;
        foreach (int num in array)
        {
            if (IsPerfectNumber(num))
            {
                lastPerfect = num;
            }
        }
        return lastPerfect;
    }

    static bool IsPerfectNumber(int num)
    {
        if (num < 1) return false;
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        return sum == num;
    }

    // 150
    static float FindMaxNegativeNumber(float[] array)
    {
        float maxNegative = 0; 
        foreach (float num in array)
        {
            if (num < 0 && (maxNegative == 0 || num > maxNegative))
            {
                maxNegative = num;
            }
        }
        return maxNegative;
    }

    // 151
    static int FindMaxPrimeNumber(int[] array)
    {
        int maxPrime = 0;
        foreach (int num in array)
        {
            if (IsPrime(num) && num > maxPrime)
            {
                maxPrime = num;
            }
        }
        return maxPrime;
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
