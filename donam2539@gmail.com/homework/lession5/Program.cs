using System;

static double bai122(double[] array)
{
    if (array.Length <= 0)
        return 0;
    double max = array[0];
    foreach (double d in array)
    {
        if (d > max)
        {
            max = d;
        }
    }
    return max;
}

static int bai123(double[] array)
{
    if (array.Length <= 0)
        return 0;
    double min = array[0];
    foreach (double d in array)
    {
        if (d < min)
        {
            min = d;
        }
    }
    return Array.IndexOf(array, min);
}

static bool bai124(int[] array)
{
    if (array.Length <= 0)
    {
        return false;
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 2004 && array[i] % 2 == 0)
        {
            return true;
        }
    }
    return false;
}

static int bai125(int[] array)
{
    // Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng.
    if (array.Length < 0)
    {
        return 0;
    }

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        bool flag = false;
        for (int j = 2; j < array[i]; j++)
        {
            if (array[i] % j == 0)
            {
                flag = true;
            }
        }

        if (!flag && array[i] < 100 && array[i] > 1)
        {
            count++;
        }
    }
    return count;
}

static double bai126(double[] array)
{
    double total = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            total += array[i];
        }
    }

    return total;
}

static double[] bai127(double[] array)
{
    Array.Sort(array);
    return array;
}

Console.WriteLine("Bai 122: Gia tri lon nhat trong mang la: " + bai122([10, 2, -4, 6]));
Console.WriteLine("Bai 123: Vi tri gia tri nho nhat trong mang la: " + bai123([10, 2, 1, -4, 6, 2]));
Console.WriteLine("Bai 124: Mang ton tai gia tri chan nho hon 2004: " + bai124([10, 2, 1, -4, 6, 2]));
Console.WriteLine("Bai 125: So luong so nguyen to < 100 trong mang la: " + bai125([10, 2, 1, -4, 6, 2]));
Console.WriteLine("Bai 126: Tong cac gia tri am trong mang :la " + bai126([10, 2, 1, -4, 6, 2, -8]));
Console.WriteLine("Bai 127: Mang sau khi sap xep tang dan: ");
double[] resultBai127 = bai127([10, 2, 1, -4, 6, 2]);
XuatMang(resultBai127);
Console.WriteLine("Bai 128: Nhap mang 1 chieu cac so thuc: ");
XuatMang(NhapMang());

static double[] NhapMang()
{
    Console.Write("Nhap so luong phan tu cua mang: ");
    double[] array = [];

    int n = 0;
    //Console.WriteLine("Nhap so luong phan tu cua mang: ");
    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        array = new double[n]; // Khởi tạo mảng với số lượng phần tử vừa nhập

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu {0}: ", i + 1);
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    else
    {
        Console.Write("Phai nhap so nguyen duong > 0");
    }
    return array;
}

static void XuatMang(double[] arr)
{
    foreach (double value in arr)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}