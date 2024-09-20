namespace Week3;

public class InputFloatArray
{
     public  static float[] GetInputFloatArray()
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
}