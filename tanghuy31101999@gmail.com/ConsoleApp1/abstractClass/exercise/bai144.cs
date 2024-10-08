﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai144 : AbstractClass
    {

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int firstPrime = FindFirstValue(array);
            Console.WriteLine("Ket qua: " + firstPrime);
        }
       

        private int FindFirstValue(int[] array)
        {
            int data = -1;
            foreach (int number in array)
            {
                if (IsPrime(number))
                {
                    data = number;
                    break;
                }
            }

            return data;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        // Method to run input/output logic

    }
}
