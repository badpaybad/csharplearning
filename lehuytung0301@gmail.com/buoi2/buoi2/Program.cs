﻿using System;

class Program
{
    static void Main()
    {
        //bai122
        static double Bai122(double[] array)
        {
            double max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        //bai123
        static int Bai123(int[] array)
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
        //bai124
        static bool Bai124(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] < 2004)
                {
                    return true;
                }
            }

            return false;
        }
        //bai125
        static bool Bai125(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        //bai126
        static double Bai126(double[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
        //bai127
        static void Bai127(double[] array)
        {
            Array.Sort(array);
        }

        //bai128
        static double[] Bai128(int size)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            return array;
        }

        //bai129
        static int[] Bai129(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        //bai130
        static void Bai130(double[] array)
        {
            Console.WriteLine("Mảng các số thực: ");
            foreach (double value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        //bai131
        static void Bai131(int[] array)
        {
            Console.WriteLine("Mảng các số nguyên: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        //bai132
        static void Bai132(int[] array)
        {
            Console.WriteLine("Các giá trị chẵn trong mảng: ");
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    Console.Write(value + " ");
                }
            }
            Console.WriteLine();
        }

        //bai133
        static void Bai133(double[] array)
        {      
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine("Vị trí " + i + ": " + array[i]);
                }
            }
        }

        //bai134
        static double Bai134(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        //bai135
        static double Bai135(double[] array)
        {
            foreach (double value in array)
            {
                if (value > 0)
                {
                    return value;
                }
            }
            return -1;
        }
        //bai136
        static int Bai136(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    return array[i];
                }
            }
            return -1;
        }

        //bai137
        static int Bai137(double[] array)
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

        //bai138
        static int Bai138(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        //bai139
        static int Bai139(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPerfectNumber(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
     
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        //bai140
        static double Bai140(double[] array)
        {
            double minPositive = -1;
            foreach (double value in array)
            {
                if (value > 0 && (minPositive == -1 || value < minPositive))
                {
                    minPositive = value;
                }
            }
            return minPositive;
        }

        //bai141
        static int Bai141(double[] array)
        {
            int minIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && (minIndex == -1 || array[i] < array[minIndex]))
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        //bai142
        static double Bai142(double[] array)
        {
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        //bai143
        static int Bai143(int[] array)
        {
            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    return value;
                }
            }
            return 1;
        }

        //bai144
        static int Bai144(int[] array)
        {
            foreach (int value in array)
            {
                if (IsPrime(value))
                {
                    return value;
                }
            }
            return -1;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        //bai145
        static int Bai145(int[] array)
        {
            foreach (int value in array)
            {
                if (IsPerfectNumber(value))
                {
                    return value;
                }
            }
            return -1;
        }

        //bai146
        static double Bai146(double[] array)
        {
            foreach (double value in array)
            {
                if (value < 0)
                {
                    return value;
                }
            }
            return 1;
        }

        //bai147
        static double Bai147(double[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    return array[i];
                }
            }
            return -1;
        }

        //bai148
        static int Bai148(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPrime(array[i]))
                {
                    return array[i];
                }
            }
            return -1;
        }

        //bai149
        static int Bai149(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPerfectNumber(array[i]))
                {
                    return array[i];
                }
            }
            return -1;
        }

        //bai150
        static double Bai150(double[] array)
        {
            double maxNegative = 0;
            foreach (double value in array)
            {
                if (value < 0 && (maxNegative == 0 || value > maxNegative))
                {
                    maxNegative = value;
                }
            }
            return maxNegative;
        }

        //bai151
        static int Bai151(int[] array)
        {
            int maxPrime = 0;
            foreach (int value in array)
            {
                if (IsPrime(value) && value > maxPrime)
                {
                    maxPrime = value;
                }
            }
            return maxPrime;
        }

        //bai152
        static int Bai152(int[] array)
        {
            int minPerfect = 0;
            foreach (int value in array)
            {
                if (IsPerfectNumber(value) && (minPerfect == 0 || value < minPerfect))
                {
                    minPerfect = value;
                }
            }
            return minPerfect;
        }

        //bai153
        static int Bai153(int[] array)
        {
            int minEven = -1;
            foreach (int value in array)
            {
                if (value % 2 == 0 && (minEven == -1 || value < minEven))
                {
                    minEven = value;
                }
            }
            return minEven;
        }

        //bai154
        static int Bai154(double[] array)
        {
            int maxNegativeIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && (maxNegativeIndex == -1 || array[i] > array[maxNegativeIndex]))
                {
                    maxNegativeIndex = i;
                }
            }
            return maxNegativeIndex;
        }
    }

    }