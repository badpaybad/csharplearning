using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon bai can lam:");
        Console.WriteLine("122. Tim gia tri lon nhat trong mang cac so thuc.");
        Console.WriteLine("123. Tim vi tri gia tri nho nhat trong mang cac so nguyen.");
        Console.WriteLine("124. Kiem tra ton tai gia tri chan nho hon 2004 trong mang cac so nguyen.");
        Console.Write("Nhap lua chon cua ban (122/123/124): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 122 || choice >124)
        {
            Console.Write("Lua chon khong hop le. Vui long nhap lai (122/123/124): ");
        }

        switch (choice)
        {
            case 122:
                double[] doubleArray = InputDoubleArray();
                double maxValue = FindMaxValue(doubleArray);
                Console.WriteLine("Gia tri lon nhat trong mang la: " + maxValue);
                break;

            case 123:
                int[] intArray1 = InputIntArray();
                int minIndex = FindMinValueIndex(intArray1);
                Console.WriteLine("Vi tri gia tri nho nhat trong mang la: " + minIndex);
                Console.WriteLine("Gia tri nho nhat la: " + intArray1[minIndex]);
                break;

            case 124:
                int[] intArray2 = InputIntArray();
                bool exists = CheckEvenLessThan2004(intArray2);
                Console.WriteLine("Co ton tai gia tri chan nho hon 2004: " + (exists ? "Co" : "Khong"));
                break;
        }
    }

    static double[] InputDoubleArray()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong cho so luong phan tu: ");
        }

        double[] array = new double[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array[{i}] = ");
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Vui long nhap mot so thuc hop le: ");
            }
            array[i] = value;
        }
        return array;
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

    static double FindMaxValue(double[] array)
    {
        double max = array[0];
        foreach (double num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static int FindMinValueIndex(int[] array)
    {
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    static bool CheckEvenLessThan2004(int[] array)
    {
        foreach (int num in array)
        {
            if (num < 2004 && num % 2 == 0)
            {
                return true;
            }
        }
        return false;
    }
}
