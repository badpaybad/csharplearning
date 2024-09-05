
class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Tim gia tri duong nho nhat trong mang mot chieu so thuc.");
        Console.WriteLine("2. Tim vi tri cua gia tri duong nho nhat trong mang mot chieu so thuc.");
        Console.WriteLine("3. Tim gia tri nho nhat trong mang mot chieu so thuc.");
        Console.Write("Nhap lua chon cua ban (1/2/3): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Lua chon khong hop le. Vui long nhap lai (1/2/3): ");
        }

        switch (choice)
        {
            case 1:
                double[] doubleArray = InputDoubleArray();
                double smallestPositive = FindSmallestPositiveValue(doubleArray);
                if (smallestPositive == -1)
                {
                    Console.WriteLine("Mang khong co gia tri duong.");
                }
                else
                {
                    Console.WriteLine("Gia tri duong nho nhat trong mang la: " + smallestPositive);
                }
                break;

            case 2:
                double[] doubleArrayForPosition = InputDoubleArray();
                int smallestPositivePosition = FindSmallestPositiveValuePosition(doubleArrayForPosition);
                if (smallestPositivePosition == -1)
                {
                    Console.WriteLine("Mang khong co gia tri duong.");
                }
                else
                {
                    Console.WriteLine("Vi tri cua gia tri duong nho nhat trong mang la: " + smallestPositivePosition);
                }
                break;

            case 3:
                double[] doubleArrayForMin = InputDoubleArray();
                double minValue = FindMinValue(doubleArrayForMin);
                Console.WriteLine("Gia tri nho nhat trong mang la: " + minValue);
                break;
        }
    }


    // ham chung nhap phan tu array

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

    //140

    static double FindSmallestPositiveValue(double[] array)
    {
        double smallestPositive = -1;

        foreach (double num in array)
        {
            if (num > 0 && (smallestPositive == -1 || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }

        return smallestPositive;
    }


    //141

    static int FindSmallestPositiveValuePosition(double[] array)
    {
        int position = -1;
        double smallestPositive = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && (smallestPositive == -1 || array[i] < smallestPositive))
            {
                smallestPositive = array[i];
                position = i;
            }
        }

        return position;
    }



    // 142
    static double FindMinValue(double[] array)
    {
        if (array.Length == 0) return double.MaxValue;

        double minValue = array[0];

        foreach (double num in array)
        {
            if (num < minValue)
            {
                minValue = num;
            }
        }

        return minValue;
    }





}
