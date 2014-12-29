using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactorization
{
    class TestingClass
    {
        [TestFixture]
        public class PrimeTests
        {
            [Test]
            public void DivisorsOfZeroOrOne()
            {
                Assert.That(PrimeFactorization.Program.IsPrime(1), Is.False);
                Assert.That(PrimeFactorization.Program.IsPrime(0), Is.False);
            }

            [Test]
            public void TheseShouldBePrime()
            {
                var primes = new List<int> { 2, 3, 5, 7, 11, 13, 19, 23 };
                foreach (int prime in primes)
                {
                    Assert.That(PrimeFactorization.Program.IsPrime(prime), Is.True);
                }
            }

            [Test]
            public void TheseShouldNotBePrime()
            {
                var notPrimes = new List<int> { 4, 6, 8, 9, 12, 27, 99 };
                foreach (int notPrime in notPrimes)
                {
                    Assert.That(PrimeFactorization.Program.IsPrime(notPrime), Is.False, string.Format("{0}", notPrime));
                }
            }
        }

        [TestFixture]
        public class PrimesLessThanOrEqualToTests
        {
            [Test]
            public void NoPrimesBelowZeroOrOne()
            {
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(0), Is.EquivalentTo(new List<int>()));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(1), Is.EquivalentTo(new List<int>()));
            }

            [Test]
            public void PrimesBelowSmallNumbers()
            {
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(2), Is.EquivalentTo(new List<int> { 2 }));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(3), Is.EquivalentTo(new List<int> { 2, 3 }));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(4), Is.EquivalentTo(new List<int> { 2, 3 }));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(5), Is.EquivalentTo(new List<int> { 2, 3, 5 }));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(6), Is.EquivalentTo(new List<int> { 2, 3, 5 }));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(7), Is.EquivalentTo(new List<int> { 2, 3, 5, 7 }));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(19),
                    Is.EquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 }));
            }

            [Test]
            public void PrimesBelowALargeNumber()
            {
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(99),
                    Is.EquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }));
            }
        }

        [TestFixture]
        public class GetPrimeFactorsTests
        {
            [Test]
            public void PrimeFactorsOfZeroOrOne()
            {
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(0), Is.EquivalentTo(new List<int>()));
                Assert.That(PrimeFactorization.Program.PrimesLessThanOrEqualTo(1), Is.EquivalentTo(new List<int>()));
            }

            [Test]
            public void PrimeFactorsOfPrimes()
            {
                var primes = new List<int> { 2, 3, 5, 7, 11, 13, 19, 23 };
                foreach (var prime in primes)
                {
                    Assert.That(PrimeFactorization.Program.GetPrimeFactors(prime), Is.EquivalentTo(new List<int> { prime }));
                }
            }

            [Test]
            public void PrimeFactorsOfSmallNumbers()
            {
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(10), Is.EquivalentTo(new List<int> { 2, 5 }));
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(8), Is.EquivalentTo(new List<int> { 2 }));
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(12), Is.EquivalentTo(new List<int> { 2, 3 }));
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(99), Is.EquivalentTo(new List<int> { 3, 11 }));
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(35), Is.EquivalentTo(new List<int> { 5, 7 }));
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(630), Is.EquivalentTo(new List<int> { 2, 3, 5, 7 }));
            }

            [Test]
            public void PrimeFactorizationOfHugeNumber()
            {
                Assert.That(PrimeFactorization.Program.GetPrimeFactors(65532), Is.EquivalentTo(new List<int> { 2, 3, 43, 127 }));
            }
        }
    }
}
