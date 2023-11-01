using System;

namespace B_E_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (CalcAvg(60, 60, 60) > 60)
            {
                Console.WriteLine("Mezun Oldunuz");
            }
            else
            {
                Console.WriteLine("Tesufki Mezun Ola bilmediniz");
            }
            Console.WriteLine(IsPrime(18));


        }
        static bool IsPrime(int x)
        {
            if (x < 4) return true;
            for (int i = 2; i*i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static double CalcAvg(params double[] arr) 
        {
            double sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return sum / arr.Length;
        }
    }
}
