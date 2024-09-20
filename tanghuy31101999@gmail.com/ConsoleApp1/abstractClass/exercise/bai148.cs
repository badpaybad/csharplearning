using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
        public class Bai148 : AbstractClass
        {
            public override void Run()
            {
                int[] array = ArrayInt.InputArray();

                int lastPrime = FindLastValue(array);

               Console.WriteLine("Ket qua: " + lastPrime);
            }
            private bool IsPrime(int number)
            {
                if (number <= 1) return false;

                if (number == 2) return true;

                if (number % 2 == 0) return false;

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            private int FindLastValue(int[] array)
            {
            int data = -1;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (IsPrime(array[i]))
                    {
                    data = array[i];
                    }
                }

                return data;
            }

            
        }

    
}
