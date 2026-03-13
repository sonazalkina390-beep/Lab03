using System;
using System.Diagnostics;

namespace Lab03
{
    // Класс для хранения результата проверки
    public class PrimeResult
    {
        public bool IsPrime { get; set; }
        public long OperationCount { get; set; } // Количество выполненных элементарных операций (например, делений или сравнений)
        public double ExecutionTimeMs { get; set; } // Время выполнения в миллисекундах
    }

    public static class PrimeChecker
    {
        /// Наивный метод проверки на простоту. Проверяет делители от 2 до n-1.
        public static PrimeResult CheckNaive(long n)
        {
            var stopwatch = Stopwatch.StartNew();
            long opCount = 0; // Счетчик операций

            if (n <= 1)
            {
                stopwatch.Stop();
                return new PrimeResult { IsPrime = false, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
            }

            if (n == 2)
            {
                stopwatch.Stop();
                return new PrimeResult { IsPrime = true, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
            }

            for (long i = 2; i < n; i++)
            {
                opCount++; // Увеличиваем счетчик перед каждой проверкой деления
                if (n % i == 0)
                {
                    stopwatch.Stop();
                    return new PrimeResult { IsPrime = false, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
                }
            }

            stopwatch.Stop();
            return new PrimeResult { IsPrime = true, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
        }
        /// Оптимизированный метод проверки на простоту. Проверяет делители от 2 до sqrt(n).
        public static PrimeResult CheckOptimized(long n)
        {
            var stopwatch = Stopwatch.StartNew();
            long opCount = 0; // Счетчик операций

            if (n <= 1)
            {
                stopwatch.Stop();
                return new PrimeResult { IsPrime = false, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
            }

            if (n == 2)
            {
                stopwatch.Stop();
                return new PrimeResult { IsPrime = true, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
            }

            if (n % 2 == 0)
            {
                stopwatch.Stop();
                return new PrimeResult { IsPrime = false, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
            }

            long limit = (long)Math.Sqrt(n); // Вычисляем корень один раз
            opCount++; // Учитываем операцию вычисления корня

            for (long i = 3; i <= limit; i += 2) // Проверяем только нечетные числа
            {
                opCount++; // Увеличиваем счетчик перед каждой проверкой деления
                if (n % i == 0)
                {
                    stopwatch.Stop();
                    return new PrimeResult { IsPrime = false, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
                }
            }

            stopwatch.Stop();
            return new PrimeResult { IsPrime = true, OperationCount = opCount, ExecutionTimeMs = GetElapsedMs(stopwatch) };
        }

        // Вспомогательный метод для получения времени в миллисекундах
        private static double GetElapsedMs(Stopwatch stopwatch)
        {
            return stopwatch.ElapsedTicks * 1000.0 / Stopwatch.Frequency;
        }
    }
}