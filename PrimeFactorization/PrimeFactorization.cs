using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorization
{
    public class PrimeFactorization
    {
        internal class Program
        {
            public static List<int> GetPrimeFactors(int number)
            {
                var primes = PrimesLessThanOrEqualTo(number);
                return primes.Where(p => number%p == 0).ToList();
            }

            public static List<int> PrimesLessThanOrEqualTo(int number)
            {
                var primes = new List<int>();
                for (var index = 0; index <= number; index++)
                {
                    if (IsPrime(index))
                    {
                        primes.Add(index);
                    }
                }
                return primes;
            }

            public static bool IsPrime(int number)
            {
                if (number == 0 || number == 1)
                {
                    return false;
                }
                for (var index = 2; index <= number/2; index++)
                {
                    if (number%index == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}