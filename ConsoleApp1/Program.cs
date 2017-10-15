using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
			Int32 iSum = 0;
			Random rnd = new Random();
			Int32 iRnd = rnd.Next(1, 100);

			for (Int32 i = 0; i < iRnd; i++)
			{
				iSum += i;
			}
            Console.WriteLine("Rnd = {0}, Sum = {1}", iRnd, iSum);
        }
    }
}
