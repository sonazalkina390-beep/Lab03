using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab03;

namespace Lab03.Tests
{
    [TestClass]
    public class PrimeCheckerTests
    {
        // Простые числа (малые)
        [TestMethod]
        public void CheckNaive_SmallPrimes_ReturnsTrue()
        {
            Assert.IsTrue(PrimeChecker.CheckNaive(2).IsPrime);
            Assert.IsTrue(PrimeChecker.CheckNaive(3).IsPrime);
            Assert.IsTrue(PrimeChecker.CheckNaive(5).IsPrime);
            Assert.IsTrue(PrimeChecker.CheckNaive(7).IsPrime);
        }

        [TestMethod]
        public void CheckOptimized_SmallPrimes_ReturnsTrue()
        {
            Assert.IsTrue(PrimeChecker.CheckOptimized(2).IsPrime);
            Assert.IsTrue(PrimeChecker.CheckOptimized(3).IsPrime);
            Assert.IsTrue(PrimeChecker.CheckOptimized(5).IsPrime);
            Assert.IsTrue(PrimeChecker.CheckOptimized(7).IsPrime);
        }

        // Составные числа
        [TestMethod]
        public void CheckNaive_Composites_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.CheckNaive(4).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckNaive(6).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckNaive(9).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckNaive(15).IsPrime);
        }

        [TestMethod]
        public void CheckOptimized_Composites_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.CheckOptimized(4).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckOptimized(6).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckOptimized(9).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckOptimized(15).IsPrime);
        }

        // Граничные случаи (n ≤ 1)
        [TestMethod]
        public void CheckNaive_NonPositive_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.CheckNaive(1).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckNaive(0).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckNaive(-5).IsPrime);
        }

        [TestMethod]
        public void CheckOptimized_NonPositive_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.CheckOptimized(1).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckOptimized(0).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckOptimized(-5).IsPrime);
        }

        // Чётные > 2 → всегда составные
        [TestMethod]
        public void CheckNaive_EvenGreaterThan2_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.CheckNaive(100).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckNaive(999998).IsPrime);
        }

        [TestMethod]
        public void CheckOptimized_EvenGreaterThan2_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.CheckOptimized(100).IsPrime);
            Assert.IsFalse(PrimeChecker.CheckOptimized(999998).IsPrime);
        }

        // Большое простое число (999983 — известное простое < 1e6)
        [TestMethod]
        public void CheckOptimized_LargePrime_ReturnsTrue()
        {
            Assert.IsTrue(PrimeChecker.CheckOptimized(999983).IsPrime);
        }

        // Сравнение результатов двух алгоритмов
        [TestMethod]
        public void Algorithms_GiveIdenticalResults()
        {
            long[] cases = { 2, 3, 4, 5, 9, 17, 101, 1009, 999983 };

            foreach (long n in cases)
            {
                PrimeResult r1 = PrimeChecker.CheckNaive(n);
                PrimeResult r2 = PrimeChecker.CheckOptimized(n);

                Assert.AreEqual(r1.IsPrime, r2.IsPrime,
                    $"Разница в результате для n = {n}");
            }
        }

        // Оптимизированный использует меньше операций (для n > 100)
        [TestMethod]
        public void Optimized_UsesFewerOperations()
        {
            long n = 1009; // простое ~1000

            PrimeResult naive = PrimeChecker.CheckNaive(n);
            PrimeResult opt = PrimeChecker.CheckOptimized(n);

            Assert.IsTrue(opt.OperationCount < naive.OperationCount,
                $"Оптимизированный ({opt.OperationCount}) не меньше наивного ({naive.OperationCount}) для n={n}");
        }

        // Проверка отсутствия исключений (MSTest: если исключение — тест падает)
        [TestMethod]
        public void CheckAlgorithms_NoExceptionOnValidInput()
        {
            long[] inputs = { 2, 100, 10000, 999983 };
            foreach (long n in inputs)
            {
                // Если здесь будет исключение — тест провалится автоматически
                PrimeChecker.CheckNaive(n);
                PrimeChecker.CheckOptimized(n);
            }
        }
    }
}