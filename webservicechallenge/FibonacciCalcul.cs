// <copyright file="FibonacciCalcul.cs" company="Made by ME">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebServiceChallenge
{
    public static class FibonacciCalcul
    {
        /// <summary>Gets the fibonacci value.</summary>
        /// <param name="value">The input value.</param>
        /// <returns>Fibonacci value.</returns>
        public static long GetFibonacci(int value)
        {
            if (value < 2)
            {
                return (long)value;
            }

            long a = 0;
            long b = 1;
            long result = 0;
            for (int i = 1; i < value; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}