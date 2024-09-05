using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Tim gia tri am dau tien trong mang mot chieu so thuc.");
        Console.WriteLine("2. Tim so duong cuoi cung trong mang so thuc.");
        Console.WriteLine("3. Tim so nguyen to cuoi cung trong mang mot chieu so nguyen.");
        Console.Write("Nhap lua chon cua ban (1/2/3): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Lua chon khong hop le. Vui long nhap lai (1/2/3): ");
        }

        switch (choice)
        {
            case 1:
                float[] floatArray = InputFloatArray();
                float firstNegative = FindFirstNegativeNumber(floatArray);
                if (firstNegative == 1)
                {
                    Console.WriteLine("Mang khong co gia tri am.");
                }
                else
                {
                    Console.WriteLine("Gia tri am dau tien trong mang la: " + firstNegative);
                }
                break;

            case 2:
                float[] floatArrayForPositive = InputFloatArray();
                float lastPositive = FindLastPositiveNumber(floatArrayForPositive);
                if (lastPositive == -1)
                {
                    Console.WriteLine("Mang khong co gia tri duong.");
                }
                else
                {
                    Console.WriteLine("So duong cuoi cung trong mang la: " + lastPositive);
                }
                break;

            case 3:
                int[] intArray = InputIntArray();
                int lastPrime = FindLastPrimeNumber(intArray);
                if (lastPrime == -1)
                {
                    Console.WriteLine("Mang khong co so nguyen to.");
                }
                else
                {
                    Console.WriteLine("So nguyen to cuoi cung trong mang la: " + lastPrime);
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


    // 146

    static float FindFirstNegativeNumber(float[] array)
    {
        foreach (float num in array)
        {
            if (num < 0)
            {
                return num;
            }
        }
        return 1; // Không có giá trị âm
    }

    // 147
    static float FindLastPositiveNumber(float[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                return array[i];
            }
        }
        return -1; // Không có giá trị dương
    }


    // 148

    static int FindLastPrimeNumber(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (IsPrime(array[i]))
            {
                return array[i];
            }
        }
        return -1; // Không có số nguyên tố
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
