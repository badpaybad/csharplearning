using system;

namespace day_1
{
    public class main
    {
        static void Main(string[] args)
        {
           
            // Bai 4

            double sumOfPart(int n)
            {
                double sum = 0;
                if (n > 0) {
                    for (int i = 1; i <= n; i++) {
                        sum += 1 / 2 * n
                    }
                }
                return sum;
            }

            //Bai 5

            double sumOfPart2(int n)
            {
                double sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += 1 / (2 * n) + 1
                }

                return sum;
            }


            // Bai 6

            double sum(int n)
            {
                
                if (n > 0)
                {
                    return 1 - 1 / (n + 1);
                }

                return 0;
            }

        }
    }