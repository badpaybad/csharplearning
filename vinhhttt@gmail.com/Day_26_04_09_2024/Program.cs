using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Tim so chan dau tien trong mang mot chieu so nguyen.");
        Console.WriteLine("2. Tim so nguyen to dau tien trong mang mot chieu so nguyen.");
        Console.WriteLine("3. Tim so hoan thien dau tien trong mang mot chieu so nguyen.");
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
                int firstEven = FindFirstEvenNumber(intArray);
                if (firstEven == -1)
                {
                    Console.WriteLine("Mang khong co so chan.");
                }
                else
                {
                    Console.WriteLine("So chan dau tien trong mang la: " + firstEven);
                }
                break;

            case 2:
                int[] intArrayForPrime = InputIntArray();
                int firstPrime = FindFirstPrimeNumber(intArrayForPrime);
                if (firstPrime == -1)
                {
                    Console.WriteLine("Mang khong co so nguyen to.");
                }
                else
                {
                    Console.WriteLine("So nguyen to dau tien trong mang la: " + firstPrime);
                }
                break;

            case 3:
                int[] intArrayForPerfect = InputIntArray();
                int firstPerfect = FindFirstPerfectNumber(intArrayForPerfect);
                if (firstPerfect == -1)
                {
                    Console.WriteLine("Mang khong co so hoan thien.");
                }
                else
                {
                    Console.WriteLine("So hoan thien dau tien trong mang la: " + firstPerfect);
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

    // 143
    static int FindFirstEvenNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                return num;
            }
        }
        return -1;
    }


    //144
    static int FindFirstPrimeNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (IsPrime(num))
            {
                return num;
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

    // 145

    static int FindFirstPerfectNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (IsPerfectNumber(num))
            {
                return num;
            }
        }
        return -1; // Không có số hoàn thiện
    }

    static bool IsPerfectNumber(int num)
    {
        if (num < 1) return false;

        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        return sum == num;
    }

}
