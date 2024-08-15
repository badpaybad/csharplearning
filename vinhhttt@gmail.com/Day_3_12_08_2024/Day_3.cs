using system;

namespace day_1
{
	public class Main
	{
		static void Main(string[] args)
		{

			// Bai 7

			double sumOfPart(int n)
			{
				double sum = 0;

				for (int i = 1; i <= n; i++)
				{
					sum += i/i+1

				}

				return sum;
			}

			//Bai 8

			double sumOfPart2(int n)
			{
				double sum = 0;

				for (int i = 1; i <= n; i++)
				{
					sum += (2*i)+1 / (2*i)+2

				}

				return sum;
			}


			// Bai 9

			int multiplication(int n)
			{

				int m = 0;
				for(int i = 1; i <= n;i++)
				{
					m *= i;

				}
				return m;
			}

		}
	}