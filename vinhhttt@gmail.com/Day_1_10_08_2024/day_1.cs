using system;

namespace day_1
{
    public class main
    {
        static void Main(string[] args) { 
            // bai 1

             int sum(int n)
            {
                return (n*(n+1)) /2;
            }


            //bai 2

             int sumOfSquares(int n)
            {
                return  (n*(n+1)(2n+1)) /n;
            }

            //bai 3

            double sumOfHarmonic(int n)
            {
                double sum = 0;

                if(n>0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        sum += 1 / i;
                    }
                }
                return sum;
            }
    }
}