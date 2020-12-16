using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevopProj
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter min number");
            int imin;
            int.TryParse(Console.ReadLine().ToString(),out imin);
            Console.WriteLine("enter max number");
            int imax;
            int.TryParse(Console.ReadLine().ToString(), out imax);
            for (int i = imin; i <= imax; i++)
            {
                if(PrimeNumber(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static bool PrimeNumber(int n)
        {
            bool isPrime = true;
            for (int i = 2; i <=n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
